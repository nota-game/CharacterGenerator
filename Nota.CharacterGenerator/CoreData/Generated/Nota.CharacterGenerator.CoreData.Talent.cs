//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 1.0.58.0.
namespace Nota.CharacterGenerator.CoreData.Talent
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.58.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("Kategorie", Namespace="http://nota-game.azurewebsites.net/schema/talent")]
    public enum Kategorie
    {
        
        /// <summary>
        /// </summary>
        Geist,
        
        /// <summary>
        /// </summary>
        Körper,
        
        /// <summary>
        /// </summary>
        Geselchaft,
        
        /// <summary>
        /// </summary>
        Kampf,
        
        /// <summary>
        /// </summary>
        Wissen,
        
        /// <summary>
        /// </summary>
        Handwerk,
    }
    
    /// <summary>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.58.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AbleitungsAuswahl", Namespace="http://nota-game.azurewebsites.net/schema/talent")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AbleitungsAuswahl
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Ableitung> _ableitung;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Ableitung", Namespace="http://nota-game.azurewebsites.net/schema/talent")]
        public System.Collections.ObjectModel.Collection<Ableitung> Ableitung
        {
            get
            {
                return this._ableitung;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="AbleitungsAuswahl" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="AbleitungsAuswahl" /> class.</para>
        /// </summary>
        public AbleitungsAuswahl()
        {
            this._ableitung = new System.Collections.ObjectModel.Collection<Ableitung>();
            this._max = new System.Collections.ObjectModel.Collection<Max>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Max> _max;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Max", Namespace="http://nota-game.azurewebsites.net/schema/talent")]
        public System.Collections.ObjectModel.Collection<Max> Max
        {
            get
            {
                return this._max;
            }
        }
    }
    
    /// <summary>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.58.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("Ableitung", Namespace="http://nota-game.azurewebsites.net/schema/talent", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Ableitung", Namespace="http://nota-game.azurewebsites.net/schema/talent")]
    public partial class Ableitung : Nota.CharacterGenerator.CoreData.Misc.INamedElement
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("Name", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public string Name { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("Anzahl", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="int")]
        public int Anzahl { get; set; }
    }
    
    /// <summary>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.58.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("Max", Namespace="http://nota-game.azurewebsites.net/schema/talent", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Max", Namespace="http://nota-game.azurewebsites.net/schema/talent")]
    public partial class Max
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Ableitung> _ableitung;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Ableitung", Namespace="http://nota-game.azurewebsites.net/schema/talent")]
        public System.Collections.ObjectModel.Collection<Ableitung> Ableitung
        {
            get
            {
                return this._ableitung;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="Max" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Max" /> class.</para>
        /// </summary>
        public Max()
        {
            this._ableitung = new System.Collections.ObjectModel.Collection<Ableitung>();
            this._maxProperty = new System.Collections.ObjectModel.Collection<Max>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Max> _maxProperty;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Max", Namespace="http://nota-game.azurewebsites.net/schema/talent")]
        public System.Collections.ObjectModel.Collection<Max> MaxProperty
        {
            get
            {
                return this._maxProperty;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _anzahl = 1;
        
        /// <summary>
        /// </summary>
        [System.ComponentModel.DefaultValueAttribute(1)]
        [System.Xml.Serialization.XmlAttributeAttribute("Anzahl", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="int")]
        public int Anzahl
        {
            get
            {
                return this._anzahl;
            }
            set
            {
                this._anzahl = value;
            }
        }
    }
    
    /// <summary>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.58.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("Talent", Namespace="http://nota-game.azurewebsites.net/schema/talent", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Talent", Namespace="http://nota-game.azurewebsites.net/schema/talent")]
    public partial class Talent : Nota.CharacterGenerator.CoreData.Misc.INamedElement
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("Name", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public string Name { get; set; }
        
        /// <summary>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("Level", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="int")]
        public int LevelValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Level-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Level property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool LevelValueSpecified { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> Level
        {
            get
            {
                if (this.LevelValueSpecified)
                {
                    return this.LevelValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LevelValue = value.GetValueOrDefault();
                this.LevelValueSpecified = value.HasValue;
            }
        }
    }
    
    /// <summary>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.58.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("Talente", Namespace="http://nota-game.azurewebsites.net/schema/talent", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Talente", Namespace="http://nota-game.azurewebsites.net/schema/talent")]
    public partial class Talente
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TalenteTalent> _talent;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Talent", Namespace="http://nota-game.azurewebsites.net/schema/talent")]
        public System.Collections.ObjectModel.Collection<TalenteTalent> Talent
        {
            get
            {
                return this._talent;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Talent-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Talent collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TalentSpecified
        {
            get
            {
                return (this.Talent.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="Talente" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Talente" /> class.</para>
        /// </summary>
        public Talente()
        {
            this._talent = new System.Collections.ObjectModel.Collection<TalenteTalent>();
        }
    }
    
    /// <summary>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.58.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TalenteTalent", Namespace="http://nota-game.azurewebsites.net/schema/talent", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TalenteTalent
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Probe", Namespace="http://nota-game.azurewebsites.net/schema/talent")]
        public TalenteTalentProbe Probe { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Beschreibung", Namespace="http://nota-game.azurewebsites.net/schema/talent", DataType="string")]
        public string Beschreibung { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TalenteTalentBedingugenBedingung> _bedingugen;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute("Bedingugen", Namespace="http://nota-game.azurewebsites.net/schema/talent")]
        [System.Xml.Serialization.XmlArrayItemAttribute("Bedingung", Namespace="http://nota-game.azurewebsites.net/schema/talent")]
        public System.Collections.ObjectModel.Collection<TalenteTalentBedingugenBedingung> Bedingugen
        {
            get
            {
                return this._bedingugen;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Bedingugen-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Bedingugen collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BedingugenSpecified
        {
            get
            {
                return (this.Bedingugen.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="TalenteTalent" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TalenteTalent" /> class.</para>
        /// </summary>
        public TalenteTalent()
        {
            this._bedingugen = new System.Collections.ObjectModel.Collection<TalenteTalentBedingugenBedingung>();
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Ableitungen", Namespace="http://nota-game.azurewebsites.net/schema/talent")]
        public Nota.CharacterGenerator.CoreData.Talent.AbleitungsAuswahl Ableitungen { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("Name", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public string Name { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("Kategorie", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Nota.CharacterGenerator.CoreData.Talent.Kategorie Kategorie { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Pattern: [A-K].</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[A-K]")]
        [System.Xml.Serialization.XmlAttributeAttribute("Komplexität", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public string Komplexität { get; set; }
    }
    
    /// <summary>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.58.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TalenteTalentProbe", Namespace="http://nota-game.azurewebsites.net/schema/talent", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TalenteTalentProbe
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<object> _mut;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Mut", Namespace="http://nota-game.azurewebsites.net/schema/talent")]
        public System.Collections.ObjectModel.Collection<object> Mut
        {
            get
            {
                return this._mut;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="TalenteTalentProbe" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TalenteTalentProbe" /> class.</para>
        /// </summary>
        public TalenteTalentProbe()
        {
            this._mut = new System.Collections.ObjectModel.Collection<object>();
            this._glück = new System.Collections.ObjectModel.Collection<object>();
            this._klugheit = new System.Collections.ObjectModel.Collection<object>();
            this._intuition = new System.Collections.ObjectModel.Collection<object>();
            this._gewandtheit = new System.Collections.ObjectModel.Collection<object>();
            this._feinmotorik = new System.Collections.ObjectModel.Collection<object>();
            this._sympathie = new System.Collections.ObjectModel.Collection<object>();
            this._antipathie = new System.Collections.ObjectModel.Collection<object>();
            this._stärke = new System.Collections.ObjectModel.Collection<object>();
            this._konstitution = new System.Collections.ObjectModel.Collection<object>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<object> _glück;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Glück", Namespace="http://nota-game.azurewebsites.net/schema/talent")]
        public System.Collections.ObjectModel.Collection<object> Glück
        {
            get
            {
                return this._glück;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<object> _klugheit;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Klugheit", Namespace="http://nota-game.azurewebsites.net/schema/talent")]
        public System.Collections.ObjectModel.Collection<object> Klugheit
        {
            get
            {
                return this._klugheit;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<object> _intuition;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Intuition", Namespace="http://nota-game.azurewebsites.net/schema/talent")]
        public System.Collections.ObjectModel.Collection<object> Intuition
        {
            get
            {
                return this._intuition;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<object> _gewandtheit;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Gewandtheit", Namespace="http://nota-game.azurewebsites.net/schema/talent")]
        public System.Collections.ObjectModel.Collection<object> Gewandtheit
        {
            get
            {
                return this._gewandtheit;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<object> _feinmotorik;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Feinmotorik", Namespace="http://nota-game.azurewebsites.net/schema/talent")]
        public System.Collections.ObjectModel.Collection<object> Feinmotorik
        {
            get
            {
                return this._feinmotorik;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<object> _sympathie;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Sympathie", Namespace="http://nota-game.azurewebsites.net/schema/talent")]
        public System.Collections.ObjectModel.Collection<object> Sympathie
        {
            get
            {
                return this._sympathie;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<object> _antipathie;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Antipathie", Namespace="http://nota-game.azurewebsites.net/schema/talent")]
        public System.Collections.ObjectModel.Collection<object> Antipathie
        {
            get
            {
                return this._antipathie;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<object> _stärke;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Stärke", Namespace="http://nota-game.azurewebsites.net/schema/talent")]
        public System.Collections.ObjectModel.Collection<object> Stärke
        {
            get
            {
                return this._stärke;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<object> _konstitution;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Konstitution", Namespace="http://nota-game.azurewebsites.net/schema/talent")]
        public System.Collections.ObjectModel.Collection<object> Konstitution
        {
            get
            {
                return this._konstitution;
            }
        }
    }
    
    /// <summary>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.58.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TalenteTalentBedingugen", Namespace="http://nota-game.azurewebsites.net/schema/talent", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TalenteTalentBedingugen
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TalenteTalentBedingugenBedingung> _bedingung;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Bedingung", Namespace="http://nota-game.azurewebsites.net/schema/talent")]
        public System.Collections.ObjectModel.Collection<TalenteTalentBedingugenBedingung> Bedingung
        {
            get
            {
                return this._bedingung;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="TalenteTalentBedingugen" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TalenteTalentBedingugen" /> class.</para>
        /// </summary>
        public TalenteTalentBedingugen()
        {
            this._bedingung = new System.Collections.ObjectModel.Collection<TalenteTalentBedingugenBedingung>();
        }
    }
    
    /// <summary>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.58.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TalenteTalentBedingugenBedingung", Namespace="http://nota-game.azurewebsites.net/schema/talent", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TalenteTalentBedingugenBedingung
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Talent> _talent;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Talent", Namespace="http://nota-game.azurewebsites.net/schema/talent")]
        public System.Collections.ObjectModel.Collection<Talent> Talent
        {
            get
            {
                return this._talent;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="TalenteTalentBedingugenBedingung" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TalenteTalentBedingugenBedingung" /> class.</para>
        /// </summary>
        public TalenteTalentBedingugenBedingung()
        {
            this._talent = new System.Collections.ObjectModel.Collection<Talent>();
            this._fertigkeit = new System.Collections.ObjectModel.Collection<Nota.CharacterGenerator.CoreData.Misc.NamedType>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Nota.CharacterGenerator.CoreData.Misc.NamedType> _fertigkeit;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Fertigkeit", Namespace="http://nota-game.azurewebsites.net/schema/fertigkeit")]
        public System.Collections.ObjectModel.Collection<Nota.CharacterGenerator.CoreData.Misc.NamedType> Fertigkeit
        {
            get
            {
                return this._fertigkeit;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("Wert", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Wert { get; set; }
    }
}
