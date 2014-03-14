/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

grammar Calc;
options
{
	language = CSharp2;
}
@parser::namespace { Generated }
@lexer::namespace  { Generated }
@header{
	using System;
	using System.Collections;
}

@members{
	Hashtable memory = new Hashtable();
}
statement
	: expr NEWLINE { Console.WriteLine($expr.value); }
	| ID '=' expr NEWLINE { memory.Add($ID.text, $expr.value); }
	| NEWLINE
	;
calc	
	: statement+
	;
expr returns[int value]	
	: me1=multExpression {$value = $me1.value;}
	('+' me2=multExpression {$value += $me2.value;}
	|'-' me2=multExpression {$value -= $me2.value;})*
	;
multExpression returns[int value]
	: a1=atom {$value = $a1.value;}
	('*' a2=atom {$value *= $a2.value;}
	|'/' a2=atom {$value /= $a2.value;})*
	;
	
atom returns[int value]
	: ID {$value = (int)memory[$ID.text];}
	| INT {$value = int.Parse($INT.text);}
	| '(' expr ')' {$value = $expr.value;}
	;
NEWLINE : '\r'? '\n' 	;
INT     : [0-9]+ ;