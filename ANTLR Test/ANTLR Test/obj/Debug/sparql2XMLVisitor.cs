//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.2-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Admin\Source\Repos\ANTLR-Test\ANTLR Test\ANTLR Test\sparql2XML.g4 by ANTLR 4.2-SNAPSHOT

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
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="sparql2XMLParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.2-SNAPSHOT")]
[System.CLSCompliant(false)]
public interface Isparql2XMLVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] sparql2XMLParser.ExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.whereClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhereClause([NotNull] sparql2XMLParser.WhereClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.varOrIRIref"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarOrIRIref([NotNull] sparql2XMLParser.VarOrIRIrefContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.graphGraphPattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGraphGraphPattern([NotNull] sparql2XMLParser.GraphGraphPatternContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.limitOffsetClauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLimitOffsetClauses([NotNull] sparql2XMLParser.LimitOffsetClausesContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.argList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgList([NotNull] sparql2XMLParser.ArgListContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.limitClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLimitClause([NotNull] sparql2XMLParser.LimitClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.prefixDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrefixDecl([NotNull] sparql2XMLParser.PrefixDeclContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.propertyListNotEmpty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPropertyListNotEmpty([NotNull] sparql2XMLParser.PropertyListNotEmptyContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.unaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnaryExpression([NotNull] sparql2XMLParser.UnaryExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.propertyList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPropertyList([NotNull] sparql2XMLParser.PropertyListContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.primaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrimaryExpression([NotNull] sparql2XMLParser.PrimaryExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionCall([NotNull] sparql2XMLParser.FunctionCallContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.solutionModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSolutionModifier([NotNull] sparql2XMLParser.SolutionModifierContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.orderCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrderCondition([NotNull] sparql2XMLParser.OrderConditionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.describeQuery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDescribeQuery([NotNull] sparql2XMLParser.DescribeQueryContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.constructQuery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstructQuery([NotNull] sparql2XMLParser.ConstructQueryContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.defaultGraphClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefaultGraphClause([NotNull] sparql2XMLParser.DefaultGraphClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.triplesSameSubject"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTriplesSameSubject([NotNull] sparql2XMLParser.TriplesSameSubjectContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.prologue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrologue([NotNull] sparql2XMLParser.PrologueContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.conditionalAndExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConditionalAndExpression([NotNull] sparql2XMLParser.ConditionalAndExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.additiveExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAdditiveExpression([NotNull] sparql2XMLParser.AdditiveExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.builtInCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBuiltInCall([NotNull] sparql2XMLParser.BuiltInCallContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.selectQuery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSelectQuery([NotNull] sparql2XMLParser.SelectQueryContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.namedGraphClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNamedGraphClause([NotNull] sparql2XMLParser.NamedGraphClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.varOrTermSub"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarOrTermSub([NotNull] sparql2XMLParser.VarOrTermSubContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.constructTriples"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstructTriples([NotNull] sparql2XMLParser.ConstructTriplesContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.iRIrefOrFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIRIrefOrFunction([NotNull] sparql2XMLParser.IRIrefOrFunctionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.constructTemplate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstructTemplate([NotNull] sparql2XMLParser.ConstructTemplateContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.filter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFilter([NotNull] sparql2XMLParser.FilterContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.multiplicativeExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiplicativeExpression([NotNull] sparql2XMLParser.MultiplicativeExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.groupOrUnionGraphPattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGroupOrUnionGraphPattern([NotNull] sparql2XMLParser.GroupOrUnionGraphPatternContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.varOrTerm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarOrTerm([NotNull] sparql2XMLParser.VarOrTermContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.query"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQuery([NotNull] sparql2XMLParser.QueryContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.var"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVar([NotNull] sparql2XMLParser.VarContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.graphTerm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGraphTerm([NotNull] sparql2XMLParser.GraphTermContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstraint([NotNull] sparql2XMLParser.ConstraintContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.regexExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRegexExpression([NotNull] sparql2XMLParser.RegexExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.triplesNode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTriplesNode([NotNull] sparql2XMLParser.TriplesNodeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.objectList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitObjectList([NotNull] sparql2XMLParser.ObjectListContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.@object"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitObject([NotNull] sparql2XMLParser.ObjectContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.collection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCollection([NotNull] sparql2XMLParser.CollectionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.triplesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTriplesBlock([NotNull] sparql2XMLParser.TriplesBlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.groupGraphPattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGroupGraphPattern([NotNull] sparql2XMLParser.GroupGraphPatternContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.orderClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrderClause([NotNull] sparql2XMLParser.OrderClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.verb"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVerb([NotNull] sparql2XMLParser.VerbContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.optionalGraphPattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOptionalGraphPattern([NotNull] sparql2XMLParser.OptionalGraphPatternContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.relationalExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRelationalExpression([NotNull] sparql2XMLParser.RelationalExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.basedecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBasedecl([NotNull] sparql2XMLParser.BasedeclContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.blankNodePropertyList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlankNodePropertyList([NotNull] sparql2XMLParser.BlankNodePropertyListContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.conditionalOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConditionalOrExpression([NotNull] sparql2XMLParser.ConditionalOrExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.numericLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumericLiteral([NotNull] sparql2XMLParser.NumericLiteralContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.numericExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumericExpression([NotNull] sparql2XMLParser.NumericExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.iRIref"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIRIref([NotNull] sparql2XMLParser.IRIrefContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.datasetClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDatasetClause([NotNull] sparql2XMLParser.DatasetClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.graphNode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGraphNode([NotNull] sparql2XMLParser.GraphNodeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.rDFLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRDFLiteral([NotNull] sparql2XMLParser.RDFLiteralContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.graphPatternNotTriples"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGraphPatternNotTriples([NotNull] sparql2XMLParser.GraphPatternNotTriplesContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.sourceSelector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSourceSelector([NotNull] sparql2XMLParser.SourceSelectorContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.numericLiteralUnsigned"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumericLiteralUnsigned([NotNull] sparql2XMLParser.NumericLiteralUnsignedContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.valueLogical"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValueLogical([NotNull] sparql2XMLParser.ValueLogicalContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.offsetClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOffsetClause([NotNull] sparql2XMLParser.OffsetClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.askQuery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAskQuery([NotNull] sparql2XMLParser.AskQueryContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparql2XMLParser.brackettedExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBrackettedExpression([NotNull] sparql2XMLParser.BrackettedExpressionContext context);
}
} // namespace ANTLR_Test
