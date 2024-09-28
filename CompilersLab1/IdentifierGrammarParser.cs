//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from IdentifierGrammar.g4 by ANTLR 4.13.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.2")]
[System.CLSCompliant(false)]
public partial class IdentifierGrammarParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, LETTER=13, DIGIT=14, WS=15;
	public const int
		RULE_z = 0, RULE_value = 1, RULE_number = 2, RULE_string = 3, RULE_symbol = 4;
	public static readonly string[] ruleNames = {
		"z", "value", "number", "string", "symbol"
	};

	private static readonly string[] _LiteralNames = {
		null, "'$'", "';'", "'='", "'.'", "'\"'", "'!'", "'&'", "'?'", "','", 
		"'/'", "' '", "'''"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, "LETTER", "DIGIT", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "IdentifierGrammar.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static IdentifierGrammarParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public IdentifierGrammarParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public IdentifierGrammarParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class ZContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LETTER() { return GetTokens(IdentifierGrammarParser.LETTER); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LETTER(int i) {
			return GetToken(IdentifierGrammarParser.LETTER, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ValueContext value() {
			return GetRuleContext<ValueContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DIGIT() { return GetTokens(IdentifierGrammarParser.DIGIT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DIGIT(int i) {
			return GetToken(IdentifierGrammarParser.DIGIT, i);
		}
		public ZContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_z; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IIdentifierGrammarListener typedListener = listener as IIdentifierGrammarListener;
			if (typedListener != null) typedListener.EnterZ(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IIdentifierGrammarListener typedListener = listener as IIdentifierGrammarListener;
			if (typedListener != null) typedListener.ExitZ(this);
		}
	}

	[RuleVersion(0)]
	public ZContext z() {
		ZContext _localctx = new ZContext(Context, State);
		EnterRule(_localctx, 0, RULE_z);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 10;
			Match(T__0);
			State = 11;
			Match(LETTER);
			State = 15;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==LETTER || _la==DIGIT) {
				{
				{
				State = 12;
				_la = TokenStream.LA(1);
				if ( !(_la==LETTER || _la==DIGIT) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				}
				}
				State = 17;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 19;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==T__2) {
				{
				State = 18;
				value();
				}
			}

			State = 21;
			Match(T__1);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ValueContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public NumberContext number() {
			return GetRuleContext<NumberContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StringContext @string() {
			return GetRuleContext<StringContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public SymbolContext symbol() {
			return GetRuleContext<SymbolContext>(0);
		}
		public ValueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_value; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IIdentifierGrammarListener typedListener = listener as IIdentifierGrammarListener;
			if (typedListener != null) typedListener.EnterValue(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IIdentifierGrammarListener typedListener = listener as IIdentifierGrammarListener;
			if (typedListener != null) typedListener.ExitValue(this);
		}
	}

	[RuleVersion(0)]
	public ValueContext value() {
		ValueContext _localctx = new ValueContext(Context, State);
		EnterRule(_localctx, 2, RULE_value);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 23;
			Match(T__2);
			State = 27;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case DIGIT:
				{
				State = 24;
				number();
				}
				break;
			case T__4:
				{
				State = 25;
				@string();
				}
				break;
			case T__11:
				{
				State = 26;
				symbol();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class NumberContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DIGIT() { return GetTokens(IdentifierGrammarParser.DIGIT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DIGIT(int i) {
			return GetToken(IdentifierGrammarParser.DIGIT, i);
		}
		public NumberContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_number; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IIdentifierGrammarListener typedListener = listener as IIdentifierGrammarListener;
			if (typedListener != null) typedListener.EnterNumber(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IIdentifierGrammarListener typedListener = listener as IIdentifierGrammarListener;
			if (typedListener != null) typedListener.ExitNumber(this);
		}
	}

	[RuleVersion(0)]
	public NumberContext number() {
		NumberContext _localctx = new NumberContext(Context, State);
		EnterRule(_localctx, 4, RULE_number);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 30;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 29;
				Match(DIGIT);
				}
				}
				State = 32;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==DIGIT );
			State = 40;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==T__3) {
				{
				State = 34;
				Match(T__3);
				State = 36;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				do {
					{
					{
					State = 35;
					Match(DIGIT);
					}
					}
					State = 38;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				} while ( _la==DIGIT );
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StringContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LETTER() { return GetTokens(IdentifierGrammarParser.LETTER); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LETTER(int i) {
			return GetToken(IdentifierGrammarParser.LETTER, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DIGIT() { return GetTokens(IdentifierGrammarParser.DIGIT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DIGIT(int i) {
			return GetToken(IdentifierGrammarParser.DIGIT, i);
		}
		public StringContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_string; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IIdentifierGrammarListener typedListener = listener as IIdentifierGrammarListener;
			if (typedListener != null) typedListener.EnterString(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IIdentifierGrammarListener typedListener = listener as IIdentifierGrammarListener;
			if (typedListener != null) typedListener.ExitString(this);
		}
	}

	[RuleVersion(0)]
	public StringContext @string() {
		StringContext _localctx = new StringContext(Context, State);
		EnterRule(_localctx, 6, RULE_string);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 42;
			Match(T__4);
			State = 46;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 28608L) != 0)) {
				{
				{
				State = 43;
				_la = TokenStream.LA(1);
				if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & 28608L) != 0)) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				}
				}
				State = 48;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 49;
			Match(T__4);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SymbolContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LETTER() { return GetToken(IdentifierGrammarParser.LETTER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DIGIT() { return GetToken(IdentifierGrammarParser.DIGIT, 0); }
		public SymbolContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_symbol; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IIdentifierGrammarListener typedListener = listener as IIdentifierGrammarListener;
			if (typedListener != null) typedListener.EnterSymbol(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IIdentifierGrammarListener typedListener = listener as IIdentifierGrammarListener;
			if (typedListener != null) typedListener.ExitSymbol(this);
		}
	}

	[RuleVersion(0)]
	public SymbolContext symbol() {
		SymbolContext _localctx = new SymbolContext(Context, State);
		EnterRule(_localctx, 8, RULE_symbol);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 51;
			Match(T__11);
			State = 52;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & 28608L) != 0)) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			State = 53;
			Match(T__11);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static int[] _serializedATN = {
		4,1,15,56,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,1,0,1,0,1,0,5,0,14,8,
		0,10,0,12,0,17,9,0,1,0,3,0,20,8,0,1,0,1,0,1,1,1,1,1,1,1,1,3,1,28,8,1,1,
		2,4,2,31,8,2,11,2,12,2,32,1,2,1,2,4,2,37,8,2,11,2,12,2,38,3,2,41,8,2,1,
		3,1,3,5,3,45,8,3,10,3,12,3,48,9,3,1,3,1,3,1,4,1,4,1,4,1,4,1,4,0,0,5,0,
		2,4,6,8,0,2,1,0,13,14,2,0,6,11,13,14,58,0,10,1,0,0,0,2,23,1,0,0,0,4,30,
		1,0,0,0,6,42,1,0,0,0,8,51,1,0,0,0,10,11,5,1,0,0,11,15,5,13,0,0,12,14,7,
		0,0,0,13,12,1,0,0,0,14,17,1,0,0,0,15,13,1,0,0,0,15,16,1,0,0,0,16,19,1,
		0,0,0,17,15,1,0,0,0,18,20,3,2,1,0,19,18,1,0,0,0,19,20,1,0,0,0,20,21,1,
		0,0,0,21,22,5,2,0,0,22,1,1,0,0,0,23,27,5,3,0,0,24,28,3,4,2,0,25,28,3,6,
		3,0,26,28,3,8,4,0,27,24,1,0,0,0,27,25,1,0,0,0,27,26,1,0,0,0,28,3,1,0,0,
		0,29,31,5,14,0,0,30,29,1,0,0,0,31,32,1,0,0,0,32,30,1,0,0,0,32,33,1,0,0,
		0,33,40,1,0,0,0,34,36,5,4,0,0,35,37,5,14,0,0,36,35,1,0,0,0,37,38,1,0,0,
		0,38,36,1,0,0,0,38,39,1,0,0,0,39,41,1,0,0,0,40,34,1,0,0,0,40,41,1,0,0,
		0,41,5,1,0,0,0,42,46,5,5,0,0,43,45,7,1,0,0,44,43,1,0,0,0,45,48,1,0,0,0,
		46,44,1,0,0,0,46,47,1,0,0,0,47,49,1,0,0,0,48,46,1,0,0,0,49,50,5,5,0,0,
		50,7,1,0,0,0,51,52,5,12,0,0,52,53,7,1,0,0,53,54,5,12,0,0,54,9,1,0,0,0,
		7,15,19,27,32,38,40,46
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
