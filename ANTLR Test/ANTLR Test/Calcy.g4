grammar Calcy;

options
{
	language = CSharp2;
}
@parser::namespace { Generated }
@lexer::namespace  { Generated }
@header
{	
	using System;
	using System.Collections;
}
@members{       
	int _base;
}
expr  returns [int s]  
:   '(' q= expr ')'
                {  $s = $q.s;  }
  | l =  expr '*' r = expr
                {
                    $s = $l.s * $r.s;
                }
        |   l = expr '/' r =  expr
                {
					$s = $l.s / $r.s;
                }
        | l =   expr '%'  r = expr
                {
				$s = $l.s % $r.s;
                }
        |  l =  expr '+' r =  expr
                {
				$s = $l.s + $r.s;                
                }
        | l =  expr '-'  r =  expr
                {
				$s = $l.s - $r.s;
                }
        |   number
		{
			 $s = $number.t	;
		}
        ;

number returns [int t] :   DIGIT
                {
                    $t = int.Parse($DIGIT.text);
                    _base = ($t==0) ? 8 : 10;
                }
			|   number DIGIT
                {
                    $t = _base * $t + int.Parse($DIGIT.text);
                }
        ;
DIGIT :[0-9];