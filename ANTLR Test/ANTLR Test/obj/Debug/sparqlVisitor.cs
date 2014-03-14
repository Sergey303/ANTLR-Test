//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.2-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\Users\Admin\Source\Repos\ANTLR-Test\ANTLR Test\ANTLR Test\sparql.g4 by ANTLR 4.2-SNAPSHOT

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
/// by <see cref="sparqlParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.2-SNAPSHOT")]
[System.CLSCompliant(false)]
public interface IsparqlVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] sparqlParser.ExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.whereClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhereClause([NotNull] sparqlParser.WhereClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.varOrIRIref"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarOrIRIref([NotNull] sparqlParser.VarOrIRIrefContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.graphGraphPattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGraphGraphPattern([NotNull] sparqlParser.GraphGraphPatternContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.limitOffsetClauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLimitOffsetClauses([NotNull] sparqlParser.LimitOffsetClausesContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.argList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgList([NotNull] sparqlParser.ArgListContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.limitClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLimitClause([NotNull] sparqlParser.LimitClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.prefixDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrefixDecl([NotNull] sparqlParser.PrefixDeclContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.propertyListNotEmpty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPropertyListNotEmpty([NotNull] sparqlParser.PropertyListNotEmptyContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.unaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnaryExpression([NotNull] sparqlParser.UnaryExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.propertyList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPropertyList([NotNull] sparqlParser.PropertyListContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.primaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrimaryExpression([NotNull] sparqlParser.PrimaryExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionCall([NotNull] sparqlParser.FunctionCallContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.solutionModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSolutionModifier([NotNull] sparqlParser.SolutionModifierContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.orderCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrderCondition([NotNull] sparqlParser.OrderConditionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.describeQuery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDescribeQuery([NotNull] sparqlParser.DescribeQueryContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.constructQuery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstructQuery([NotNull] sparqlParser.ConstructQueryContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.defaultGraphClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefaultGraphClause([NotNull] sparqlParser.DefaultGraphClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.triplesSameSubject"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTriplesSameSubject([NotNull] sparqlParser.TriplesSameSubjectContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.prologue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrologue([NotNull] sparqlParser.PrologueContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.conditionalAndExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConditionalAndExpression([NotNull] sparqlParser.ConditionalAndExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.additiveExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAdditiveExpression([NotNull] sparqlParser.AdditiveExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.builtInCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBuiltInCall([NotNull] sparqlParser.BuiltInCallContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.selectQuery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSelectQuery([NotNull] sparqlParser.SelectQueryContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.namedGraphClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNamedGraphClause([NotNull] sparqlParser.NamedGraphClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.constructTriples"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstructTriples([NotNull] sparqlParser.ConstructTriplesContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.iRIrefOrFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIRIrefOrFunction([NotNull] sparqlParser.IRIrefOrFunctionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.constructTemplate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstructTemplate([NotNull] sparqlParser.ConstructTemplateContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.filter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFilter([NotNull] sparqlParser.FilterContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.multiplicativeExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiplicativeExpression([NotNull] sparqlParser.MultiplicativeExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.groupOrUnionGraphPattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGroupOrUnionGraphPattern([NotNull] sparqlParser.GroupOrUnionGraphPatternContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.varOrTerm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarOrTerm([NotNull] sparqlParser.VarOrTermContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.query"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQuery([NotNull] sparqlParser.QueryContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.var"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVar([NotNull] sparqlParser.VarContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.graphTerm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGraphTerm([NotNull] sparqlParser.GraphTermContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstraint([NotNull] sparqlParser.ConstraintContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.regexExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRegexExpression([NotNull] sparqlParser.RegexExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.triplesNode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTriplesNode([NotNull] sparqlParser.TriplesNodeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.objectList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitObjectList([NotNull] sparqlParser.ObjectListContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.@object"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitObject([NotNull] sparqlParser.ObjectContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.collection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCollection([NotNull] sparqlParser.CollectionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.triplesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTriplesBlock([NotNull] sparqlParser.TriplesBlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.groupGraphPattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGroupGraphPattern([NotNull] sparqlParser.GroupGraphPatternContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.orderClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrderClause([NotNull] sparqlParser.OrderClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.verb"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVerb([NotNull] sparqlParser.VerbContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.optionalGraphPattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOptionalGraphPattern([NotNull] sparqlParser.OptionalGraphPatternContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.relationalExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRelationalExpression([NotNull] sparqlParser.RelationalExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.basedecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBasedecl([NotNull] sparqlParser.BasedeclContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.blankNodePropertyList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlankNodePropertyList([NotNull] sparqlParser.BlankNodePropertyListContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.conditionalOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConditionalOrExpression([NotNull] sparqlParser.ConditionalOrExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.numericLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumericLiteral([NotNull] sparqlParser.NumericLiteralContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.numericExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumericExpression([NotNull] sparqlParser.NumericExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.iRIref"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIRIref([NotNull] sparqlParser.IRIrefContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.datasetClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDatasetClause([NotNull] sparqlParser.DatasetClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.graphNode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGraphNode([NotNull] sparqlParser.GraphNodeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.rDFLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRDFLiteral([NotNull] sparqlParser.RDFLiteralContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.graphPatternNotTriples"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGraphPatternNotTriples([NotNull] sparqlParser.GraphPatternNotTriplesContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.sourceSelector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSourceSelector([NotNull] sparqlParser.SourceSelectorContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.numericLiteralUnsigned"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumericLiteralUnsigned([NotNull] sparqlParser.NumericLiteralUnsignedContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.valueLogical"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValueLogical([NotNull] sparqlParser.ValueLogicalContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.offsetClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOffsetClause([NotNull] sparqlParser.OffsetClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.askQuery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAskQuery([NotNull] sparqlParser.AskQueryContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="sparqlParser.brackettedExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBrackettedExpression([NotNull] sparqlParser.BrackettedExpressionContext context);
}
} // namespace ANTLR_Test