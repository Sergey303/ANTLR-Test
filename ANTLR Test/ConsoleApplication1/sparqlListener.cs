//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.2-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\Users\Admin\Source\Repos\ANTLR Test\ANTLR Test\sparql.g4 by ANTLR 4.2-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace ANTLR_Test {

	using System;
	using System.Xml.Linq;	
	using System.Collections;

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="sparqlParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.2-SNAPSHOT")]
[System.CLSCompliant(false)]
public interface IsparqlListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] sparqlParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] sparqlParser.ExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.whereClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhereClause([NotNull] sparqlParser.WhereClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.whereClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhereClause([NotNull] sparqlParser.WhereClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.varOrIRIref"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVarOrIRIref([NotNull] sparqlParser.VarOrIRIrefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.varOrIRIref"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVarOrIRIref([NotNull] sparqlParser.VarOrIRIrefContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.graphGraphPattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGraphGraphPattern([NotNull] sparqlParser.GraphGraphPatternContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.graphGraphPattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGraphGraphPattern([NotNull] sparqlParser.GraphGraphPatternContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.limitOffsetClauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLimitOffsetClauses([NotNull] sparqlParser.LimitOffsetClausesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.limitOffsetClauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLimitOffsetClauses([NotNull] sparqlParser.LimitOffsetClausesContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.argList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArgList([NotNull] sparqlParser.ArgListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.argList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArgList([NotNull] sparqlParser.ArgListContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.limitClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLimitClause([NotNull] sparqlParser.LimitClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.limitClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLimitClause([NotNull] sparqlParser.LimitClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.prefixDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrefixDecl([NotNull] sparqlParser.PrefixDeclContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.prefixDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrefixDecl([NotNull] sparqlParser.PrefixDeclContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.propertyListNotEmpty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPropertyListNotEmpty([NotNull] sparqlParser.PropertyListNotEmptyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.propertyListNotEmpty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPropertyListNotEmpty([NotNull] sparqlParser.PropertyListNotEmptyContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.unaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryExpression([NotNull] sparqlParser.UnaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.unaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryExpression([NotNull] sparqlParser.UnaryExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.propertyList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPropertyList([NotNull] sparqlParser.PropertyListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.propertyList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPropertyList([NotNull] sparqlParser.PropertyListContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.primaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryExpression([NotNull] sparqlParser.PrimaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.primaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryExpression([NotNull] sparqlParser.PrimaryExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCall([NotNull] sparqlParser.FunctionCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCall([NotNull] sparqlParser.FunctionCallContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.solutionModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSolutionModifier([NotNull] sparqlParser.SolutionModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.solutionModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSolutionModifier([NotNull] sparqlParser.SolutionModifierContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.orderCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrderCondition([NotNull] sparqlParser.OrderConditionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.orderCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrderCondition([NotNull] sparqlParser.OrderConditionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.describeQuery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDescribeQuery([NotNull] sparqlParser.DescribeQueryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.describeQuery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDescribeQuery([NotNull] sparqlParser.DescribeQueryContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.constructQuery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstructQuery([NotNull] sparqlParser.ConstructQueryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.constructQuery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstructQuery([NotNull] sparqlParser.ConstructQueryContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.defaultGraphClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefaultGraphClause([NotNull] sparqlParser.DefaultGraphClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.defaultGraphClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefaultGraphClause([NotNull] sparqlParser.DefaultGraphClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.triplesSameSubject"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTriplesSameSubject([NotNull] sparqlParser.TriplesSameSubjectContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.triplesSameSubject"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTriplesSameSubject([NotNull] sparqlParser.TriplesSameSubjectContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.prologue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrologue([NotNull] sparqlParser.PrologueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.prologue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrologue([NotNull] sparqlParser.PrologueContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.conditionalAndExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConditionalAndExpression([NotNull] sparqlParser.ConditionalAndExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.conditionalAndExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConditionalAndExpression([NotNull] sparqlParser.ConditionalAndExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.additiveExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditiveExpression([NotNull] sparqlParser.AdditiveExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.additiveExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditiveExpression([NotNull] sparqlParser.AdditiveExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.builtInCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBuiltInCall([NotNull] sparqlParser.BuiltInCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.builtInCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBuiltInCall([NotNull] sparqlParser.BuiltInCallContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.selectQuery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelectQuery([NotNull] sparqlParser.SelectQueryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.selectQuery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelectQuery([NotNull] sparqlParser.SelectQueryContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.namedGraphClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamedGraphClause([NotNull] sparqlParser.NamedGraphClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.namedGraphClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamedGraphClause([NotNull] sparqlParser.NamedGraphClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.constructTriples"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstructTriples([NotNull] sparqlParser.ConstructTriplesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.constructTriples"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstructTriples([NotNull] sparqlParser.ConstructTriplesContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.iRIrefOrFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIRIrefOrFunction([NotNull] sparqlParser.IRIrefOrFunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.iRIrefOrFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIRIrefOrFunction([NotNull] sparqlParser.IRIrefOrFunctionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.constructTemplate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstructTemplate([NotNull] sparqlParser.ConstructTemplateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.constructTemplate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstructTemplate([NotNull] sparqlParser.ConstructTemplateContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.filter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFilter([NotNull] sparqlParser.FilterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.filter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFilter([NotNull] sparqlParser.FilterContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.multiplicativeExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicativeExpression([NotNull] sparqlParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.multiplicativeExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicativeExpression([NotNull] sparqlParser.MultiplicativeExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.groupOrUnionGraphPattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGroupOrUnionGraphPattern([NotNull] sparqlParser.GroupOrUnionGraphPatternContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.groupOrUnionGraphPattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGroupOrUnionGraphPattern([NotNull] sparqlParser.GroupOrUnionGraphPatternContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.varOrTerm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVarOrTerm([NotNull] sparqlParser.VarOrTermContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.varOrTerm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVarOrTerm([NotNull] sparqlParser.VarOrTermContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.query"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuery([NotNull] sparqlParser.QueryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.query"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuery([NotNull] sparqlParser.QueryContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.var"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVar([NotNull] sparqlParser.VarContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.var"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVar([NotNull] sparqlParser.VarContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.graphTerm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGraphTerm([NotNull] sparqlParser.GraphTermContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.graphTerm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGraphTerm([NotNull] sparqlParser.GraphTermContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstraint([NotNull] sparqlParser.ConstraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstraint([NotNull] sparqlParser.ConstraintContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.regexExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRegexExpression([NotNull] sparqlParser.RegexExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.regexExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRegexExpression([NotNull] sparqlParser.RegexExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.triplesNode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTriplesNode([NotNull] sparqlParser.TriplesNodeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.triplesNode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTriplesNode([NotNull] sparqlParser.TriplesNodeContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.objectList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObjectList([NotNull] sparqlParser.ObjectListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.objectList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObjectList([NotNull] sparqlParser.ObjectListContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.@object"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObject([NotNull] sparqlParser.ObjectContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.@object"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObject([NotNull] sparqlParser.ObjectContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.collection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCollection([NotNull] sparqlParser.CollectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.collection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCollection([NotNull] sparqlParser.CollectionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.triplesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTriplesBlock([NotNull] sparqlParser.TriplesBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.triplesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTriplesBlock([NotNull] sparqlParser.TriplesBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.groupGraphPattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGroupGraphPattern([NotNull] sparqlParser.GroupGraphPatternContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.groupGraphPattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGroupGraphPattern([NotNull] sparqlParser.GroupGraphPatternContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.orderClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrderClause([NotNull] sparqlParser.OrderClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.orderClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrderClause([NotNull] sparqlParser.OrderClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.verb"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVerb([NotNull] sparqlParser.VerbContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.verb"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVerb([NotNull] sparqlParser.VerbContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.optionalGraphPattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOptionalGraphPattern([NotNull] sparqlParser.OptionalGraphPatternContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.optionalGraphPattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOptionalGraphPattern([NotNull] sparqlParser.OptionalGraphPatternContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.relationalExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelationalExpression([NotNull] sparqlParser.RelationalExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.relationalExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelationalExpression([NotNull] sparqlParser.RelationalExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.basedecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBasedecl([NotNull] sparqlParser.BasedeclContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.basedecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBasedecl([NotNull] sparqlParser.BasedeclContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.blankNodePropertyList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlankNodePropertyList([NotNull] sparqlParser.BlankNodePropertyListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.blankNodePropertyList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlankNodePropertyList([NotNull] sparqlParser.BlankNodePropertyListContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.conditionalOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConditionalOrExpression([NotNull] sparqlParser.ConditionalOrExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.conditionalOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConditionalOrExpression([NotNull] sparqlParser.ConditionalOrExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.numericLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumericLiteral([NotNull] sparqlParser.NumericLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.numericLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumericLiteral([NotNull] sparqlParser.NumericLiteralContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.numericExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumericExpression([NotNull] sparqlParser.NumericExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.numericExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumericExpression([NotNull] sparqlParser.NumericExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.iRIref"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIRIref([NotNull] sparqlParser.IRIrefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.iRIref"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIRIref([NotNull] sparqlParser.IRIrefContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.datasetClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDatasetClause([NotNull] sparqlParser.DatasetClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.datasetClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDatasetClause([NotNull] sparqlParser.DatasetClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.graphNode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGraphNode([NotNull] sparqlParser.GraphNodeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.graphNode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGraphNode([NotNull] sparqlParser.GraphNodeContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.rDFLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRDFLiteral([NotNull] sparqlParser.RDFLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.rDFLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRDFLiteral([NotNull] sparqlParser.RDFLiteralContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.graphPatternNotTriples"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGraphPatternNotTriples([NotNull] sparqlParser.GraphPatternNotTriplesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.graphPatternNotTriples"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGraphPatternNotTriples([NotNull] sparqlParser.GraphPatternNotTriplesContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.sourceSelector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSourceSelector([NotNull] sparqlParser.SourceSelectorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.sourceSelector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSourceSelector([NotNull] sparqlParser.SourceSelectorContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.numericLiteralUnsigned"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumericLiteralUnsigned([NotNull] sparqlParser.NumericLiteralUnsignedContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.numericLiteralUnsigned"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumericLiteralUnsigned([NotNull] sparqlParser.NumericLiteralUnsignedContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.valueLogical"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValueLogical([NotNull] sparqlParser.ValueLogicalContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.valueLogical"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValueLogical([NotNull] sparqlParser.ValueLogicalContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.offsetClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOffsetClause([NotNull] sparqlParser.OffsetClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.offsetClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOffsetClause([NotNull] sparqlParser.OffsetClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.askQuery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAskQuery([NotNull] sparqlParser.AskQueryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.askQuery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAskQuery([NotNull] sparqlParser.AskQueryContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sparqlParser.brackettedExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBrackettedExpression([NotNull] sparqlParser.BrackettedExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sparqlParser.brackettedExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBrackettedExpression([NotNull] sparqlParser.BrackettedExpressionContext context);
}
} // namespace ANTLR_Test
