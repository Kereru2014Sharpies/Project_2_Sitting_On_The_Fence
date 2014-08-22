using System;

using Mindscape.LightSpeed;
using Mindscape.LightSpeed.Validation;
using Mindscape.LightSpeed.Linq;

namespace ORMTodos
{
  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [Table("Answers")]
  public partial class Answer : Entity<int>
  {
    #region Fields
  
    [Column("Answer")]
    [ValidatePresence]
    private string _answerField;
    private int _partyId;
    private int _questionId;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the AnswerField entity attribute.</summary>
    public const string AnswerFieldField = "AnswerField";
    /// <summary>Identifies the PartyId entity attribute.</summary>
    public const string PartyIdField = "PartyId";
    /// <summary>Identifies the QuestionId entity attribute.</summary>
    public const string QuestionIdField = "QuestionId";


    #endregion
    
    #region Relationships

    [ReverseAssociation("Answers")]
    private readonly EntityHolder<Party> _party = new EntityHolder<Party>();
    [ReverseAssociation("Answers")]
    private readonly EntityHolder<Question> _question = new EntityHolder<Question>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public Party Party
    {
      get { return Get(_party); }
      set { Set(_party, value); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public Question Question
    {
      get { return Get(_question); }
      set { Set(_question, value); }
    }


    [System.Diagnostics.DebuggerNonUserCode]
    public string AnswerField
    {
      get { return Get(ref _answerField, "AnswerField"); }
      set { Set(ref _answerField, value, "AnswerField"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="Party" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public int PartyId
    {
      get { return Get(ref _partyId, "PartyId"); }
      set { Set(ref _partyId, value, "PartyId"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="Question" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public int QuestionId
    {
      get { return Get(ref _questionId, "QuestionId"); }
      set { Set(ref _questionId, value, "QuestionId"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  public partial class Party : Entity<int>
  {
    #region Fields
  
    [ValidatePresence]
    [ValidateLength(0, 50)]
    private string _partyName;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the PartyName entity attribute.</summary>
    public const string PartyNameField = "PartyName";


    #endregion
    
    #region Relationships

    [ReverseAssociation("Party")]
    private readonly EntityCollection<Answer> _answers = new EntityCollection<Answer>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<Answer> Answers
    {
      get { return Get(_answers); }
    }


    [System.Diagnostics.DebuggerNonUserCode]
    public string PartyName
    {
      get { return Get(ref _partyName, "PartyName"); }
      set { Set(ref _partyName, value, "PartyName"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [Table("Questions")]
  public partial class Question : Entity<int>
  {
    #region Fields
  
    [Column("Question")]
    [ValidatePresence]
    private string _questionField;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the QuestionField entity attribute.</summary>
    public const string QuestionFieldField = "QuestionField";


    #endregion
    
    #region Relationships

    [ReverseAssociation("Question")]
    private readonly EntityCollection<Answer> _answers = new EntityCollection<Answer>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<Answer> Answers
    {
      get { return Get(_answers); }
    }


    [System.Diagnostics.DebuggerNonUserCode]
    public string QuestionField
    {
      get { return Get(ref _questionField, "QuestionField"); }
      set { Set(ref _questionField, value, "QuestionField"); }
    }

    #endregion
  }




  /// <summary>
  /// Provides a strong-typed unit of work for working with the TODOs model.
  /// </summary>
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  public partial class TODOsUnitOfWork : Mindscape.LightSpeed.UnitOfWork
  {

    public System.Linq.IQueryable<Answer> Answers
    {
      get { return this.Query<Answer>(); }
    }
    
    public System.Linq.IQueryable<Party> Parties
    {
      get { return this.Query<Party>(); }
    }
    
    public System.Linq.IQueryable<Question> Questions
    {
      get { return this.Query<Question>(); }
    }
    
  }

}
