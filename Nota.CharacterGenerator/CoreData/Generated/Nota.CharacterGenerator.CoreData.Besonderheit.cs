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
namespace Nota.CharacterGenerator.CoreData.Besonderheit
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.58.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("BedingugsAuswahl", Namespace="http://nota-game.azurewebsites.net/schema/besonderheit")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Not", Namespace="http://nota-game.azurewebsites.net/schema/besonderheit")]
    public partial class BedingugsAuswahl
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Or", Namespace="http://nota-game.azurewebsites.net/schema/besonderheit")]
        public BedingugsAuswahlen Or { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("And", Namespace="http://nota-game.azurewebsites.net/schema/besonderheit")]
        public BedingugsAuswahlen And { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Not", Namespace="http://nota-game.azurewebsites.net/schema/besonderheit")]
        public BedingugsAuswahl Not { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Besonderheit", Namespace="http://nota-game.azurewebsites.net/schema/besonderheit")]
        public Nota.CharacterGenerator.CoreData.Misc.NamedType Besonderheit { get; set; }
    }
    
    /// <summary>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.58.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("BedingugsAuswahlen", Namespace="http://nota-game.azurewebsites.net/schema/besonderheit")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Or", Namespace="http://nota-game.azurewebsites.net/schema/besonderheit")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(And))]
    public partial class BedingugsAuswahlen
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<BedingugsAuswahlen> _or;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Or", Namespace="http://nota-game.azurewebsites.net/schema/besonderheit")]
        public System.Collections.ObjectModel.Collection<BedingugsAuswahlen> Or
        {
            get
            {
                return this._or;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="BedingugsAuswahlen" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="BedingugsAuswahlen" /> class.</para>
        /// </summary>
        public BedingugsAuswahlen()
        {
            this._or = new System.Collections.ObjectModel.Collection<BedingugsAuswahlen>();
            this._and = new System.Collections.ObjectModel.Collection<BedingugsAuswahlen>();
            this._not = new System.Collections.ObjectModel.Collection<BedingugsAuswahl>();
            this._besonderheit = new System.Collections.ObjectModel.Collection<Nota.CharacterGenerator.CoreData.Misc.NamedType>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<BedingugsAuswahlen> _and;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("And", Namespace="http://nota-game.azurewebsites.net/schema/besonderheit")]
        public System.Collections.ObjectModel.Collection<BedingugsAuswahlen> And
        {
            get
            {
                return this._and;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<BedingugsAuswahl> _not;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Not", Namespace="http://nota-game.azurewebsites.net/schema/besonderheit")]
        public System.Collections.ObjectModel.Collection<BedingugsAuswahl> Not
        {
            get
            {
                return this._not;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Nota.CharacterGenerator.CoreData.Misc.NamedType> _besonderheit;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Besonderheit", Namespace="http://nota-game.azurewebsites.net/schema/besonderheit")]
        public System.Collections.ObjectModel.Collection<Nota.CharacterGenerator.CoreData.Misc.NamedType> Besonderheit
        {
            get
            {
                return this._besonderheit;
            }
        }
    }
    
    /// <summary>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.58.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Besonderheit", Namespace="http://nota-game.azurewebsites.net/schema/besonderheit")]
    public partial class Besonderheit : Nota.CharacterGenerator.CoreData.Misc.NamedType
    {
    }
    
    /// <summary>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.58.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("And", Namespace="http://nota-game.azurewebsites.net/schema/besonderheit")]
    public partial class And : BedingugsAuswahlen
    {
    }
    
    /// <summary>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.58.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("Besonderheiten", Namespace="http://nota-game.azurewebsites.net/schema/besonderheit", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Besonderheiten", Namespace="http://nota-game.azurewebsites.net/schema/besonderheit")]
    public partial class Besonderheiten
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<BesonderheitenBesonderheit> _besonderheit;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Besonderheit", Namespace="http://nota-game.azurewebsites.net/schema/besonderheit")]
        public System.Collections.ObjectModel.Collection<BesonderheitenBesonderheit> Besonderheit
        {
            get
            {
                return this._besonderheit;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Besonderheit-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Besonderheit collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BesonderheitSpecified
        {
            get
            {
                return (this.Besonderheit.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="Besonderheiten" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Besonderheiten" /> class.</para>
        /// </summary>
        public Besonderheiten()
        {
            this._besonderheit = new System.Collections.ObjectModel.Collection<BesonderheitenBesonderheit>();
        }
    }
    
    /// <summary>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.58.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("BesonderheitenBesonderheit", Namespace="http://nota-game.azurewebsites.net/schema/besonderheit", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BesonderheitenBesonderheit : Nota.CharacterGenerator.CoreData.Misc.INamedElement, Nota.CharacterGenerator.CoreData.Misc.IKostenElement
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Beschreibung", Namespace="http://nota-game.azurewebsites.net/schema/besonderheit", DataType="string")]
        public string Beschreibung { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Verbessert", Namespace="http://nota-game.azurewebsites.net/schema/besonderheit")]
        public BesonderheitenBesonderheitVerbessert Verbessert { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Bedingung", Namespace="http://nota-game.azurewebsites.net/schema/besonderheit")]
        public Nota.CharacterGenerator.CoreData.Besonderheit.BedingugsAuswahl Bedingung { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("Name", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public string Name { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _kosten = 0;
        
        /// <summary>
        /// </summary>
        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("Kosten", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="int")]
        public int Kosten
        {
            get
            {
                return this._kosten;
            }
            set
            {
                this._kosten = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _gebunden = false;
        
        /// <summary>
        /// <para xml:lang="de">
        ///                  Dieses Element beschreibt Besonderheiten, welche nicht frei zur verfügung stehen, sondern nur in Kombination mit einem anderen Element wie Einer Art erhalten werden kann.
        ///                </para>
        /// </summary>
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("Gebunden", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="boolean")]
        public bool Gebunden
        {
            get
            {
                return this._gebunden;
            }
            set
            {
                this._gebunden = value;
            }
        }
    }
    
    /// <summary>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.58.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("BesonderheitenBesonderheitVerbessert", Namespace="http://nota-game.azurewebsites.net/schema/besonderheit", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BesonderheitenBesonderheitVerbessert
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Besonderheit", Namespace="http://nota-game.azurewebsites.net/schema/besonderheit")]
        public Nota.CharacterGenerator.CoreData.Misc.NamedType Besonderheit { get; set; }
    }
}
