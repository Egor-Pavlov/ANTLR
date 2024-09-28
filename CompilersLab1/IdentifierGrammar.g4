grammar IdentifierGrammar;

// Основное правило для идентификатора
z: '$' LETTER (LETTER | DIGIT)* (value)? ';';

// Правило для значений
value: '=' (number | string | symbol);

// Правило для чисел
number: DIGIT+ ('.' DIGIT+)?;

// Правило для строк
string: '"' (LETTER | DIGIT | '!' | '&' | '?' | ',' | '/' | ' ')* '"';

// Правило для символов
symbol: '\'' (LETTER | DIGIT | '!' | '&' | '?' | ',' | '/' | ' ') '\'';

// Лексические правила для букв и цифр
LETTER: [a-zA-Z];
DIGIT: [0-9];

// Игнорируем пробелы и символы перевода строки
WS: [ \t\r\n]+ -> skip;
