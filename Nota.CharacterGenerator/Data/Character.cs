using System;
using Midgard;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Nota.CharacterGenerator.CoreData.Core;
using System.Linq;
using System.Collections.ObjectModel;
using Nota.CharacterGenerator.CoreData.Kultur;
using Nota.CharacterGenerator.CoreData.Misc;
using Nota.CharacterGenerator.CoreData.Besonderheit;
using Nota.CharacterGenerator.CoreData.Profession;

namespace Nota.CharacterGenerator.Data
{
    public class Character : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public static void Generate(Nota.CharacterGenerator.CoreData.Core.Daten daten)
        {
            var c = new Character();
            var s1 = new GeneratorStepOne(c, daten);
        }



        private class GeneratorStepOne
        {
            private readonly Character c;
            private readonly Daten daten;

            public GeneratorStepOne(Character c, Daten daten)
            {
                this.c = c;
                this.daten = daten;

                PossibleLebewesen = daten.Lebewesene.Where(x => x.Morphe.Any(y => y.Lebensabschnitte.Any(z => z.Spielbar != null))).OrderBy(x => x.Name).ToList().AsReadOnly();
                PossibleMorphe = new ReadOnlyObservableCollection<CoreData.Lebewesen.Morph>(this.possibleMorphe);
                PossibleLebensabschnitte = new ReadOnlyObservableCollection<CoreData.Lebewesen.Lebensabschnitt>(this.possibleLebensabschnitte);

                PossibleKultures = this.possibleKultures.AsObservableGrouping(x => x.Kultur, kultur => kultur.Name, element => element.Level.Name);
                PossibleProfessions = this.possibleProfessions.AsObservableGrouping(x => x.Profession, professions => professions.Name, element => element.Level.Name);

            }

            public IReadOnlyList<CoreData.Lebewesen.LebeweseneLebewesen> PossibleLebewesen { get; }
            private CoreData.Lebewesen.LebeweseneLebewesen selectedLebewesen;
            public CoreData.Lebewesen.LebeweseneLebewesen SelectedLebewesen
            {
                get => this.selectedLebewesen;
                set
                {

                    this.selectedLebewesen = value;
                    if (value == null)
                    {
                        this.possibleMorphe.Clear();
                        SelectedMorph = null;
                    }
                    else
                    {
                        var newValues = value.Morphe.Where(x => x.Lebensabschnitte.Any(y => y.Spielbar != null)).OrderBy(x => x.Name);
                        this.possibleMorphe.Syncronize(newValues);
                        if (!PossibleMorphe.Contains(SelectedMorph))
                            SelectedMorph = null;
                    }
                    RefreshFixedBesonderheiten();
                }
            }

            private void RefreshFixedBesonderheiten()
            {
                var newValues = Enumerable.Empty<BesonderheitenBesonderheit>();
                Concat(SelectedLebewesen?.Besonderheiten);
                Concat(SelectedMorph?.Mods?.Besonderheiten);
                Concat(SelectedLebensabschnitte?.Mods?.Besonderheiten);

                Concat(this.selectedKulturLevel.SelectMany(l => l.Level.Besonderheit));
                Concat(this.selectedProfessionLevel.SelectMany(l => l.Level.Besonderheit));

                var grouped = newValues.GroupBy(x => x).ToArray();

                FixedBesonderheitenDuplicateCosts = grouped.SelectMany(x => x.Skip(1)).Sum(x => x.Kosten);
                newValues = grouped.Select(x => x.Key);

                this.fixedBesonderheiten.Syncronize(newValues);

                void Concat(System.Collections.IEnumerable toAppend) =>
                    newValues = newValues.Concat(toAppend?.Cast<BesonderheitenBesonderheit>() ?? newValues);
            }

            private ObservableCollection<CoreData.Lebewesen.Morph> possibleMorphe = new ObservableCollection<CoreData.Lebewesen.Morph>();
            private ReadOnlyObservableCollection<CoreData.Lebewesen.Morph> PossibleMorphe { get; }
            public CoreData.Lebewesen.Morph selectedMorph;
            public CoreData.Lebewesen.Morph SelectedMorph
            {
                get => selectedMorph;
                set
                {
                    this.selectedMorph = value;
                    if (value == null)
                    {
                        this.possibleLebensabschnitte.Clear();
                        SelectedLebensabschnitte = null;
                    }
                    else
                    {
                        var newValues = value.Lebensabschnitte.Where(x => x.Spielbar != null).OrderBy(x => x.Name);
                        this.possibleLebensabschnitte.Syncronize(newValues);
                        if (!PossibleLebensabschnitte.Contains(SelectedLebensabschnitte))
                            SelectedLebensabschnitte = null;
                    }
                    RefreshFixedBesonderheiten();
                }
            }

            private ObservableCollection<CoreData.Lebewesen.Lebensabschnitt> possibleLebensabschnitte = new ObservableCollection<CoreData.Lebewesen.Lebensabschnitt>();
            public ReadOnlyObservableCollection<CoreData.Lebewesen.Lebensabschnitt> PossibleLebensabschnitte { get; }
            private CoreData.Lebewesen.Lebensabschnitt selectedLebensabschnitte;
            public CoreData.Lebewesen.Lebensabschnitt SelectedLebensabschnitte
            {
                get => selectedLebensabschnitte;

                set
                {
                    this.selectedLebensabschnitte = value;
                    if (value == null)
                    {
                        this.possibleKultures.Clear();
                    }
                    else
                    {
                        var newElements = this.daten.Kulturen.SelectMany(kultur => kultur.Levels.Where(level => CheckLevelPrerequest(level, kultur)).Select(level => (Kultur: kultur, Level: level)));
                        this.possibleKultures.Syncronize(newElements);
                    }
                    RefreshFixedBesonderheiten();
                }
            }

            public int FixedBesonderheitenDuplicateCosts { get; private set; }

            private readonly ObservableCollection<(ProfessionenProfession Profession, LevelsLevel Level)> possibleProfessions = new ObservableCollection<(ProfessionenProfession Profession, LevelsLevel Level)>();
            private readonly ObservableCollection<(ProfessionenProfession Profession, LevelsLevel Level)> selectedProfessionLevel = new ObservableCollection<(ProfessionenProfession Profession, LevelsLevel Level)>();
            private readonly ObservableCollection<(KulturenKultur Kultur, LevelsLevel Level)> possibleKultures = new ObservableCollection<(KulturenKultur, LevelsLevel)>();
            private readonly ObservableCollection<(KulturenKultur Kultur, LevelsLevel Level)> selectedKulturLevel = new ObservableCollection<(KulturenKultur Kultur, LevelsLevel Level)>();
            private readonly ObservableCollection<CoreData.Besonderheit.BesonderheitenBesonderheit> fixedBesonderheiten = new ObservableCollection<CoreData.Besonderheit.BesonderheitenBesonderheit>();

            public Midgard.Collections.ObservableGroupCollection<KulturenKultur, (KulturenKultur Kultur, LevelsLevel Level)> PossibleKultures { get; }
            public Midgard.Collections.ObservableGroupCollection<ProfessionenProfession, (ProfessionenProfession Profession, LevelsLevel Level)> PossibleProfessions { get; }

            private bool CheckLevelPrerequest(LevelsLevel y, KulturenKultur kultur)
            {
                var singelElement = y.Bedingungen.LevelVoraussetzung;
                return CheckLevel(singelElement, kultur) && CheckFixedBedingung(y.Bedingungen.Besonderheiten);
            }

            #region CheckBedingung
            private bool CheckFixedBedingung(BedingugsAuswahl singelElement)
            {
                if (singelElement.And != null)
                    return CheckFixedBedingugAnd(singelElement.And);
                if (singelElement.Or != null)
                    return CheckFixedBedingugOr(singelElement.And);
                if (singelElement.Not != null)
                    return !CheckFixedBedingung(singelElement.Not);

                if (singelElement.Besonderheit != null)
                    return this.fixedBesonderheiten.Contains(singelElement.Besonderheit);
                return true;
            }

            private bool CheckFixedBedingugAnd(BedingugsAuswahlen and)
            {
                if (and.And != null && !and.And.All(x => CheckFixedBedingugAnd(x)))
                    return false;
                if (and.Or != null && !and.Or.All(x => CheckFixedBedingugOr(x)))
                    return false;
                if (and.Not != null && !and.Not.All(x => !CheckFixedBedingung(x)))
                    return false;

                if (and.Besonderheit != null && !and.Besonderheit.All(x => this.fixedBesonderheiten.Contains(x)))
                    return false;

                return true;
            }

            private bool CheckFixedBedingugOr(BedingugsAuswahlen or)
            {
                if (or.And != null && or.And.Any(x => CheckFixedBedingugAnd(x)))
                    return true;
                if (or.Or != null && or.Or.Any(x => CheckFixedBedingugOr(x)))
                    return true;
                if (or.Not != null && or.Not.Any(x => !CheckFixedBedingung(x)))
                    return true;

                if (or.Besonderheit != null && or.Besonderheit.Any(x => this.fixedBesonderheiten.Contains(x)))
                    return true;

                return false;
            }
            #endregion

            private bool CheckLevel(LevelAuswahl singelElement, KulturenKultur kultur)
            {
                if (singelElement.And != null)
                    return CheckLevelAnd(singelElement.And, kultur);
                if (singelElement.Or != null)
                    return CheckLevelOr(singelElement.And, kultur);
                if (singelElement.Not != null)
                    return !CheckLevel(singelElement.Not, kultur);

                if (singelElement.Level != null)
                    return this.selectedKulturLevel.Contains((kultur, singelElement.Level.ToLevel(kultur)));
                return true;
            }

            private bool CheckLevelOr(LevelAuswahlen or, KulturenKultur kultur)
            {
                if (or.And != null && or.And.Any(x => CheckLevelAnd(x, kultur)))
                    return true;
                if (or.Or != null && or.Or.Any(x => CheckLevelOr(x, kultur)))
                    return true;
                if (or.Not != null && or.Not.Any(x => !CheckLevel(x, kultur)))
                    return true;

                if (or.Level != null && or.Level.Any(x => this.selectedKulturLevel.Contains((kultur, x.ToLevel(kultur)))))
                    return true;

                return false;
            }

            private bool CheckLevelAnd(LevelAuswahlen and, KulturenKultur kultur)
            {
                if (and.And != null && !and.And.All(x => CheckLevelAnd(x, kultur)))
                    return false;
                if (and.Or != null && !and.Or.All(x => CheckLevelOr(x, kultur)))
                    return false;
                if (and.Not != null && !and.Not.All(x => !CheckLevel(x, kultur)))
                    return false;

                if (and.Level != null && !and.Level.All(x => this.selectedKulturLevel.Contains((kultur, x.ToLevel(kultur)))))
                    return false;

                return true;
            }

            private bool CheckLevel(LevelAuswahl singelElement, ProfessionenProfession profession)
            {
                if (singelElement.And != null)
                    return CheckLevelAnd(singelElement.And, profession);
                if (singelElement.Or != null)
                    return CheckLevelOr(singelElement.And, profession);
                if (singelElement.Not != null)
                    return !CheckLevel(singelElement.Not, profession);

                if (singelElement.Level != null)
                    return this.selectedProfessionLevel.Contains((profession, singelElement.Level.ToLevel(profession)));
                return true;
            }

            private bool CheckLevelOr(LevelAuswahlen or, ProfessionenProfession profession)
            {
                if (or.And != null && or.And.Any(x => CheckLevelAnd(x, profession)))
                    return true;
                if (or.Or != null && or.Or.Any(x => CheckLevelOr(x, profession)))
                    return true;
                if (or.Not != null && or.Not.Any(x => !CheckLevel(x, profession)))
                    return true;

                if (or.Level != null && or.Level.Any(x => this.selectedProfessionLevel.Contains((profession, x.ToLevel(profession)))))
                    return true;

                return false;
            }

            private bool CheckLevelAnd(LevelAuswahlen and, ProfessionenProfession profession)
            {
                if (and.And != null && !and.And.All(x => CheckLevelAnd(x, profession)))
                    return false;
                if (and.Or != null && !and.Or.All(x => CheckLevelOr(x, profession)))
                    return false;
                if (and.Not != null && !and.Not.All(x => !CheckLevel(x, profession)))
                    return false;

                if (and.Level != null && !and.Level.All(x => this.selectedProfessionLevel.Contains((profession, x.ToLevel(profession)))))
                    return false;

                return true;
            }





            public void Commit()
            {

            }
        }

    }
}
