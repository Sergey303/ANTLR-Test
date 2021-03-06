//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.2-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Admin\Source\Repos\ANTLR-Test\ANTLR Test\ANTLR Test\sparql2Pac.g4 by ANTLR 4.2-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace ANTLR_Test {

	using System;
	using System.Linq;
	using System.Xml.Linq;	
	using System.Collections.Generic;
	using System.Text.RegularExpressions;
    using Sparql;
    using TrueRdfViewer;
	using System.Linq.Expressions;

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="sparql2PacParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.2-SNAPSHOT")]
[System.CLSCompliant(false)]
public interface Isparql2PacListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] sparql2PacParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] sparql2PacParser.ExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.varOrIRIref"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVarOrIRIref([NotNull] sparql2PacParser.VarOrIRIrefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.varOrIRIref"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVarOrIRIref([NotNull] sparql2PacParser.VarOrIRIrefContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.whereClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhereClause([NotNull] sparql2PacParser.WhereClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.whereClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhereClause([NotNull] sparql2PacParser.WhereClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.graphGraphPattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGraphGraphPattern([NotNull] sparql2PacParser.GraphGraphPatternContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.graphGraphPattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGraphGraphPattern([NotNull] sparql2PacParser.GraphGraphPatternContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.numeric"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumeric([NotNull] sparql2PacParser.NumericContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.numeric"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumeric([NotNull] sparql2PacParser.NumericContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.limitOffsetClauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLimitOffsetClauses([NotNull] sparql2PacParser.LimitOffsetClausesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.limitOffsetClauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLimitOffsetClauses([NotNull] sparql2PacParser.LimitOffsetClausesContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.argList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArgList([NotNull] sparql2PacParser.ArgListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.argList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArgList([NotNull] sparql2PacParser.ArgListContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.limitClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLimitClause([NotNull] sparql2PacParser.LimitClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.limitClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLimitClause([NotNull] sparql2PacParser.LimitClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.prefixDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrefixDecl([NotNull] sparql2PacParser.PrefixDeclContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.prefixDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrefixDecl([NotNull] sparql2PacParser.PrefixDeclContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.propertyListNotEmpty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPropertyListNotEmpty([NotNull] sparql2PacParser.PropertyListNotEmptyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.propertyListNotEmpty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPropertyListNotEmpty([NotNull] sparql2PacParser.PropertyListNotEmptyContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.unaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryExpression([NotNull] sparql2PacParser.UnaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.unaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryExpression([NotNull] sparql2PacParser.UnaryExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.varLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVarLiteral([NotNull] sparql2PacParser.VarLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.varLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVarLiteral([NotNull] sparql2PacParser.VarLiteralContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.propertyList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPropertyList([NotNull] sparql2PacParser.PropertyListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.propertyList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPropertyList([NotNull] sparql2PacParser.PropertyListContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.primaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryExpression([NotNull] sparql2PacParser.PrimaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.primaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryExpression([NotNull] sparql2PacParser.PrimaryExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.verbObjectListConstruct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVerbObjectListConstruct([NotNull] sparql2PacParser.VerbObjectListConstructContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.verbObjectListConstruct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVerbObjectListConstruct([NotNull] sparql2PacParser.VerbObjectListConstructContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCall([NotNull] sparql2PacParser.FunctionCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCall([NotNull] sparql2PacParser.FunctionCallContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.solutionModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSolutionModifier([NotNull] sparql2PacParser.SolutionModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.solutionModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSolutionModifier([NotNull] sparql2PacParser.SolutionModifierContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.graphNodeConstruct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGraphNodeConstruct([NotNull] sparql2PacParser.GraphNodeConstructContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.graphNodeConstruct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGraphNodeConstruct([NotNull] sparql2PacParser.GraphNodeConstructContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.orderCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrderCondition([NotNull] sparql2PacParser.OrderConditionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.orderCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrderCondition([NotNull] sparql2PacParser.OrderConditionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.varOrTermConstruct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVarOrTermConstruct([NotNull] sparql2PacParser.VarOrTermConstructContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.varOrTermConstruct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVarOrTermConstruct([NotNull] sparql2PacParser.VarOrTermConstructContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.describeQuery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDescribeQuery([NotNull] sparql2PacParser.DescribeQueryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.describeQuery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDescribeQuery([NotNull] sparql2PacParser.DescribeQueryContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.constructQuery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstructQuery([NotNull] sparql2PacParser.ConstructQueryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.constructQuery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstructQuery([NotNull] sparql2PacParser.ConstructQueryContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.defaultGraphClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefaultGraphClause([NotNull] sparql2PacParser.DefaultGraphClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.defaultGraphClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefaultGraphClause([NotNull] sparql2PacParser.DefaultGraphClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.triplesSameSubject"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTriplesSameSubject([NotNull] sparql2PacParser.TriplesSameSubjectContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.triplesSameSubject"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTriplesSameSubject([NotNull] sparql2PacParser.TriplesSameSubjectContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.prologue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrologue([NotNull] sparql2PacParser.PrologueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.prologue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrologue([NotNull] sparql2PacParser.PrologueContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.conditionalAndExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConditionalAndExpression([NotNull] sparql2PacParser.ConditionalAndExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.conditionalAndExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConditionalAndExpression([NotNull] sparql2PacParser.ConditionalAndExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.additiveExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditiveExpression([NotNull] sparql2PacParser.AdditiveExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.additiveExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditiveExpression([NotNull] sparql2PacParser.AdditiveExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.builtInCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBuiltInCall([NotNull] sparql2PacParser.BuiltInCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.builtInCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBuiltInCall([NotNull] sparql2PacParser.BuiltInCallContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.selectQuery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelectQuery([NotNull] sparql2PacParser.SelectQueryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.selectQuery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelectQuery([NotNull] sparql2PacParser.SelectQueryContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.namedGraphClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamedGraphClause([NotNull] sparql2PacParser.NamedGraphClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.namedGraphClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamedGraphClause([NotNull] sparql2PacParser.NamedGraphClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.varOrTermSub"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVarOrTermSub([NotNull] sparql2PacParser.VarOrTermSubContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.varOrTermSub"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVarOrTermSub([NotNull] sparql2PacParser.VarOrTermSubContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.constructTriples"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstructTriples([NotNull] sparql2PacParser.ConstructTriplesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.constructTriples"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstructTriples([NotNull] sparql2PacParser.ConstructTriplesContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.iRIrefOrFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIRIrefOrFunction([NotNull] sparql2PacParser.IRIrefOrFunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.iRIrefOrFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIRIrefOrFunction([NotNull] sparql2PacParser.IRIrefOrFunctionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.constructTemplate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstructTemplate([NotNull] sparql2PacParser.ConstructTemplateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.constructTemplate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstructTemplate([NotNull] sparql2PacParser.ConstructTemplateContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.filter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFilter([NotNull] sparql2PacParser.FilterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.filter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFilter([NotNull] sparql2PacParser.FilterContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.multiplicativeExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicativeExpression([NotNull] sparql2PacParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.multiplicativeExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicativeExpression([NotNull] sparql2PacParser.MultiplicativeExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.groupOrUnionGraphPattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGroupOrUnionGraphPattern([NotNull] sparql2PacParser.GroupOrUnionGraphPatternContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.groupOrUnionGraphPattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGroupOrUnionGraphPattern([NotNull] sparql2PacParser.GroupOrUnionGraphPatternContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.verbObjectList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVerbObjectList([NotNull] sparql2PacParser.VerbObjectListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.verbObjectList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVerbObjectList([NotNull] sparql2PacParser.VerbObjectListContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.varOrTerm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVarOrTerm([NotNull] sparql2PacParser.VarOrTermContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.varOrTerm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVarOrTerm([NotNull] sparql2PacParser.VarOrTermContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.var"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVar([NotNull] sparql2PacParser.VarContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.var"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVar([NotNull] sparql2PacParser.VarContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.query"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuery([NotNull] sparql2PacParser.QueryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.query"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuery([NotNull] sparql2PacParser.QueryContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.graphTerm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGraphTerm([NotNull] sparql2PacParser.GraphTermContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.graphTerm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGraphTerm([NotNull] sparql2PacParser.GraphTermContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstraint([NotNull] sparql2PacParser.ConstraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstraint([NotNull] sparql2PacParser.ConstraintContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.regexExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRegexExpression([NotNull] sparql2PacParser.RegexExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.regexExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRegexExpression([NotNull] sparql2PacParser.RegexExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.triplesNode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTriplesNode([NotNull] sparql2PacParser.TriplesNodeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.triplesNode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTriplesNode([NotNull] sparql2PacParser.TriplesNodeContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.collection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCollection([NotNull] sparql2PacParser.CollectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.collection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCollection([NotNull] sparql2PacParser.CollectionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.objectList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObjectList([NotNull] sparql2PacParser.ObjectListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.objectList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObjectList([NotNull] sparql2PacParser.ObjectListContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.triplesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTriplesBlock([NotNull] sparql2PacParser.TriplesBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.triplesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTriplesBlock([NotNull] sparql2PacParser.TriplesBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.propertyListNotEmptyConstruct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPropertyListNotEmptyConstruct([NotNull] sparql2PacParser.PropertyListNotEmptyConstructContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.propertyListNotEmptyConstruct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPropertyListNotEmptyConstruct([NotNull] sparql2PacParser.PropertyListNotEmptyConstructContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.groupGraphPattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGroupGraphPattern([NotNull] sparql2PacParser.GroupGraphPatternContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.groupGraphPattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGroupGraphPattern([NotNull] sparql2PacParser.GroupGraphPatternContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.orderClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrderClause([NotNull] sparql2PacParser.OrderClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.orderClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrderClause([NotNull] sparql2PacParser.OrderClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.verb"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVerb([NotNull] sparql2PacParser.VerbContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.verb"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVerb([NotNull] sparql2PacParser.VerbContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.optionalGraphPattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOptionalGraphPattern([NotNull] sparql2PacParser.OptionalGraphPatternContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.optionalGraphPattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOptionalGraphPattern([NotNull] sparql2PacParser.OptionalGraphPatternContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.basedecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBasedecl([NotNull] sparql2PacParser.BasedeclContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.basedecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBasedecl([NotNull] sparql2PacParser.BasedeclContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.blankNodePropertyList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlankNodePropertyList([NotNull] sparql2PacParser.BlankNodePropertyListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.blankNodePropertyList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlankNodePropertyList([NotNull] sparql2PacParser.BlankNodePropertyListContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.numericLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumericLiteral([NotNull] sparql2PacParser.NumericLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.numericLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumericLiteral([NotNull] sparql2PacParser.NumericLiteralContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.iRIref"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIRIref([NotNull] sparql2PacParser.IRIrefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.iRIref"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIRIref([NotNull] sparql2PacParser.IRIrefContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.graphNode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGraphNode([NotNull] sparql2PacParser.GraphNodeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.graphNode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGraphNode([NotNull] sparql2PacParser.GraphNodeContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.datasetClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDatasetClause([NotNull] sparql2PacParser.DatasetClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.datasetClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDatasetClause([NotNull] sparql2PacParser.DatasetClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.rDFLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRDFLiteral([NotNull] sparql2PacParser.RDFLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.rDFLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRDFLiteral([NotNull] sparql2PacParser.RDFLiteralContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.graphPatternNotTriples"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGraphPatternNotTriples([NotNull] sparql2PacParser.GraphPatternNotTriplesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.graphPatternNotTriples"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGraphPatternNotTriples([NotNull] sparql2PacParser.GraphPatternNotTriplesContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.sourceSelector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSourceSelector([NotNull] sparql2PacParser.SourceSelectorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.sourceSelector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSourceSelector([NotNull] sparql2PacParser.SourceSelectorContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.verbConstruct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVerbConstruct([NotNull] sparql2PacParser.VerbConstructContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.verbConstruct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVerbConstruct([NotNull] sparql2PacParser.VerbConstructContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.varOrTermSubConstruct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVarOrTermSubConstruct([NotNull] sparql2PacParser.VarOrTermSubConstructContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.varOrTermSubConstruct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVarOrTermSubConstruct([NotNull] sparql2PacParser.VarOrTermSubConstructContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.numericLiteralUnsigned"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumericLiteralUnsigned([NotNull] sparql2PacParser.NumericLiteralUnsignedContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.numericLiteralUnsigned"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumericLiteralUnsigned([NotNull] sparql2PacParser.NumericLiteralUnsignedContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.valueLogical"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValueLogical([NotNull] sparql2PacParser.ValueLogicalContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.valueLogical"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValueLogical([NotNull] sparql2PacParser.ValueLogicalContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.offsetClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOffsetClause([NotNull] sparql2PacParser.OffsetClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.offsetClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOffsetClause([NotNull] sparql2PacParser.OffsetClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.objectListConstruct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObjectListConstruct([NotNull] sparql2PacParser.ObjectListConstructContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.objectListConstruct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObjectListConstruct([NotNull] sparql2PacParser.ObjectListConstructContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.graphTermConstuct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGraphTermConstuct([NotNull] sparql2PacParser.GraphTermConstuctContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.graphTermConstuct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGraphTermConstuct([NotNull] sparql2PacParser.GraphTermConstuctContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.askQuery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAskQuery([NotNull] sparql2PacParser.AskQueryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.askQuery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAskQuery([NotNull] sparql2PacParser.AskQueryContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.triplesSameSubjectConstruct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTriplesSameSubjectConstruct([NotNull] sparql2PacParser.TriplesSameSubjectConstructContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.triplesSameSubjectConstruct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTriplesSameSubjectConstruct([NotNull] sparql2PacParser.TriplesSameSubjectConstructContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparql2PacParser.brackettedExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBrackettedExpression([NotNull] sparql2PacParser.BrackettedExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparql2PacParser.brackettedExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBrackettedExpression([NotNull] sparql2PacParser.BrackettedExpressionContext context);
}
} // namespace ANTLR_Test
