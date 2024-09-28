grammar IdentifierGrammar;

// �������� ������� ��� ��������������
z: '$' LETTER (LETTER | DIGIT)* (value)? ';';

// ������� ��� ��������
value: '=' (number | string | symbol);

// ������� ��� �����
number: DIGIT+ ('.' DIGIT+)?;

// ������� ��� �����
string: '"' (LETTER | DIGIT | '!' | '&' | '?' | ',' | '/' | ' ')* '"';

// ������� ��� ��������
symbol: '\'' (LETTER | DIGIT | '!' | '&' | '?' | ',' | '/' | ' ') '\'';

// ����������� ������� ��� ���� � ����
LETTER: [a-zA-Z];
DIGIT: [0-9];

// ���������� ������� � ������� �������� ������
WS: [ \t\r\n]+ -> skip;
