/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

grammar sparql;
options
{
	language = CSharp2;
}
@parser::namespace { Generated }
@lexer::namespace  { Generated }
@header{
	using System;
	using System.Xml.Linq;	
	using System.Collections;
}

@members{
	
	XElement x=new XElement("sparql"), spo=new XElement("spo");
}

query	 : prologue ( selectQuery | constructQuery | describeQuery | askQuery )
 {
	Console.WriteLine("ok"); 
} ;	 
prologue	 :basedecl? prefixDecl*;
basedecl	 :'BASE' IRI_REF ;
prefixDecl	 :'PREFIX'  PNAME_NS IRI_REF  
{
	x.Add(new XElement("prefix",new XElement("name", $PNAME_NS.text), new XElement("name", $IRI_REF.text)));
} ;
selectQuery	 :'SELECT'	 { x.Add(new XElement("select"));  } 
( 'DISTINCT' {	x.Element("select").Add(new XElement("DISTINCT"));} 
| 'REDUCED' {	x.Element("select").Add(new XElement("REDUCED"));}
)? 
( (var 
	{	x.Element("select").Add(new XElement("variable", $var.text));} 
)+ 
| '*'
{ 	x.Element("select").Add(new XElement("all_variables"));	} )
datasetClause* whereClause solutionModifier ;
constructQuery	 :'CONSTRUCT' constructTemplate datasetClause* whereClause solutionModifier;
describeQuery	 :'DESCRIBE' ( varOrIRIref+ | '*' ) datasetClause* whereClause? solutionModifier  ;
askQuery	 :'ASK' datasetClause* whereClause;
datasetClause	 :'FROM' ( defaultGraphClause | namedGraphClause )	;
defaultGraphClause	 :sourceSelector;
namedGraphClause	 :'NAMED' sourceSelector	;
sourceSelector	 :IRIref;
whereClause	 :'WHERE'?
{
   x.Add(new XElement("WHERE")); 
} groupGraphPattern;
solutionModifier	 :orderClause? limitOffsetClauses?	;
limitOffsetClauses	 :( limitClause offsetClause? | offsetClause limitClause? )  ;
orderClause	 :'ORDER' 'BY' orderCondition+	;
orderCondition	 : ( ( 'ASC' | 'DESC' ) brackettedExpression ) |( constraint | var )	  ;
limitClause	 :'LIMIT' INTEGER;
offsetClause	 :'OFFSET' INTEGER;
groupGraphPattern	 :'{' triplesBlock? ( ( graphPatternNotTriples | filter ) '.'? triplesBlock? )* '}'	;
triplesBlock	 :triplesSameSubject ( '.' triplesBlock? )?	  ;
graphPatternNotTriples	 : optionalGraphPattern | groupOrUnionGraphPattern | graphGraphPattern ;
optionalGraphPattern	 :'OPTIONAL' groupGraphPattern ;
graphGraphPattern	 :'GRAPH' varOrIRIref groupGraphPattern;
groupOrUnionGraphPattern	 :groupGraphPattern ( 'UNION' groupGraphPattern )*  ;
filter	 :'FILTER' constraint	 ;
constraint	 :brackettedExpression | builtInCall | functionCall	;
functionCall	 :IRIref argList;
argList	 :( NIL | '(' expression ( ',' expression )* ')' )	 ;
constructTemplate	 :'{' constructTriples? '}'  ;
constructTriples	 :triplesSameSubject ( '.' constructTriples? )?	;
triplesSameSubject	 :varOrTerm propertyListNotEmpty 
{				   
            Console.WriteLine($triplesSameSubject.text+"1");	
          x.Element("WHERE").Add(spo=new XElement("spo"));
} |	triplesNode propertyList	 ;
propertyListNotEmpty	 :verb objectList ( ';' ( verb objectList )? )*  ;
propertyList	 :propertyListNotEmpty? ;
objectList	 :
object {	 x.Element("WHERE").Add(spo=new XElement("o")); } 
( ',' 
object {	 x.Element("WHERE").Add(spo=new XElement("o")); } 
)*;
object	 :graphNode	;
verb	 :varOrIRIref {	 x.Element("WHERE").Add(spo=new XElement("p")); } | 'a' {	 x.Element("WHERE").Add(spo=new XElement("p")); spo.Add(new XElement("IRIref", "rdtf type")); } ;
triplesNode	 :collection |	blankNodePropertyList;
blankNodePropertyList	 :'[' propertyListNotEmpty ']';
collection	 :'(' graphNode+ ')'	;
graphNode	 :varOrTerm |	triplesNode	;
varOrTerm	
 : var {	            Console.WriteLine($var.text+"2"); spo.Add(new XElement("var", $var.text)); } 
| graphTerm;
varOrIRIref	 :var | IRIref;
var	 :VAR1 | VAR2;
graphTerm 	 
:	IRIref 	{	 spo.Add(new XElement("IRIref", $IRIref.text)); } 
|	RDFLiteral {	 spo.Add(new XElement("RDFLiteral", $RDFLiteral.text)); } 
|	numericLiteral {	 spo.Add(new XElement("numericLiteral", $numericLiteral.text)); } 
|	BooleanLiteral {	 spo.Add(new XElement("BooleanLiteral", $BooleanLiteral.text)); } 
|	BlankNode  {	 spo.Add(new XElement("BlankNode", $BlankNode.text)); } 
|	NIL	{	 spo.Add(new XElement("NIL")); }   ;
expression	 :conditionalOrExpression ;
conditionalOrExpression	 :conditionalAndExpression ( '||' conditionalAndExpression )*	;
conditionalAndExpression	 :valueLogical ( '&&' valueLogical )*	;
valueLogical	 :relationalExpression;
relationalExpression	 :numericExpression ( '=' numericExpression | '!=' numericExpression | '<' numericExpression | '>' numericExpression | '<=' numericExpression | '>=' numericExpression )? ;
numericExpression	 : additiveExpression ;
additiveExpression	 : multiplicativeExpression ( '+' multiplicativeExpression | '-' multiplicativeExpression | numericLiteralPositive | numericLiteralNegative )* ;
multiplicativeExpression	 :unaryExpression ( '*' unaryExpression | '/' unaryExpression )* ;
unaryExpression	 :  '!' primaryExpression 
|	'+' primaryExpression 
|	'-' primaryExpression 
|	primaryExpression  ;															   
primaryExpression	 : brackettedExpression | builtInCall | iRIrefOrFunction | RDFLiteral | numericLiteral | BooleanLiteral | var ;
brackettedExpression	 :'(' expression ')' ;
builtInCall	 :  'STR' '(' expression ')' 
|	'LANG' '(' expression ')' 
|	'LANGMATCHES' '(' expression ',' expression ')' 
|	'DATATYPE' '(' expression ')' 
|	'BOUND' '(' var ')' 
|	'sameTerm' '(' expression ',' expression ')' 
|	'isIRI' '(' expression ')' 
|	'isURI' '(' expression ')' 
|	'isBLANK' '(' expression ')' 
|	'isLITERAL' '(' expression ')' 
|	regexExpression  ;
regexExpression	 :'REGEX' '(' expression ',' expression ( ',' expression )? ')' ;
iRIrefOrFunction	 :IRIref argList? ;
RDFLiteral	 :String ( LANGTAG | ( '^^' IRIref ) )? ;
numericLiteral	 : numericLiteralUnsigned | numericLiteralPositive | numericLiteralNegative ;
numericLiteralUnsigned	 :INTEGER |	DECIMAL |	DOUBLE ;
numericLiteralPositive	 :INTEGER_POSITIVE |	DECIMAL_POSITIVE |	DOUBLE_POSITIVE ;
numericLiteralNegative	 :INTEGER_NEGATIVE |	DECIMAL_NEGATIVE |	DOUBLE_NEGATIVE	 ;

BooleanLiteral	 :'true' |	'false' ;
String	 :STRING_LITERAL1 | STRING_LITERAL2 | STRING_LITERAL_LONG1 | STRING_LITERAL_LONG2 ;
BlankNode	 :BLANK_NODE_LABEL |	ANON ;


IRI_REF	: '<'([a-zA-Zà-ÿÀ-ß0-9:/\\#.\x00-\x20-])*'>';
PNAME_NS	 : PN_PREFIX? ':';
IRIref	 :IRI_REF |	PREFIXED_NAME ;
PREFIXED_NAME	 : PNAME_LN | PNAME_NS ;

PNAME_LN	 :PNAME_NS PN_LOCAL ;
BLANK_NODE_LABEL	 :'_:' PN_LOCAL ;
VAR1	 :'?' VARNAME ;
VAR2	 :'$' VARNAME	 ;
LANGTAG	 :'@' [a-zA-Z]+ ('-' [a-zA-Z0-9]+)* ;
INTEGER	 :[0-9]+   ;
DECIMAL	 :[0-9]+ '.' [0-9]* | '.' [0-9]+ ;
DOUBLE	 :[0-9]+ '.' [0-9]* EXPONENT | '.' ([0-9])+ EXPONENT | ([0-9])+ EXPONENT ;
INTEGER_POSITIVE	 :'+' INTEGER	;
DECIMAL_POSITIVE	 :'+' DECIMAL;
DOUBLE_POSITIVE	 :'+' DOUBLE;
INTEGER_NEGATIVE	 :'-' INTEGER	 ;
DECIMAL_NEGATIVE	 :'-' DECIMAL;
DOUBLE_NEGATIVE	 :'-' DOUBLE;
EXPONENT	 :[eE] [+-]? [0-9]+;
STRING_LITERAL1	 :'\'' (.| ECHAR )*? '\''  ;
STRING_LITERAL2	 : '"'(.| ECHAR)*?'"';
STRING_LITERAL_LONG1	 :'\'\'\'' ( ( '\'' | '\'\'\'' )? ( ~[\'\\] | ECHAR ) )* '\'\'\'' ;
STRING_LITERAL_LONG2	 :'"""' ( ( '"' | '""' )? ( ~["\\] | ECHAR ) )* '"""'  ;
ECHAR	 : '\\' [tbnrf\"\'] ;
NIL	 :'(' WS* ')';
WS  :   [ \t\n\r]+ -> skip ;
ANON	 :'[' WS* ']'	;
PN_CHARS_BASE	 : [A-Z] | [a-z] | [\u00C0-\u00D6] | [\u00D8-\u00F6] | [\u00F8-\u02FF] | [\u0370-\u037D] | [\u037F-\u1FFF] | [\u200C-\u200D] | [\u2070-\u218F] | [\u2C00-\u2FEF] | [\u3001-\uD7FF] | [\uF900-\uFDCF] | [\uFDF0-\uFFFD] | [\u10000-\uEFFFF] ;
PN_CHARS_U	 :PN_CHARS_BASE | '_' ;			 
VARNAME	 :( PN_CHARS_U | [0-9] ) ( PN_CHARS_U | [0-9] | '\u00B7' | [\u0300-\u036F] | [\u203F-\u2040] )* ;
PN_CHARS	 : PN_CHARS_U | '-' | [0-9] | '\u00B7' | [\u0300-\u036F] | [\u203F-\u2040];
PN_PREFIX	 : PN_CHARS_BASE ((PN_CHARS|'.')* PN_CHARS)?;
PN_LOCAL	 : ( PN_CHARS_U | [0-9] ) ((PN_CHARS|'.')* PN_CHARS)?;