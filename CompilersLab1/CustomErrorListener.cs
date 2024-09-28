using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompilersLab1 { 
    class CustomErrorListener : IAntlrErrorListener<int>, IAntlrErrorListener<IToken>
    {
        private readonly StringBuilder _errors = new StringBuilder();

        public void SyntaxError(TextWriter output, IRecognizer recognizer, int offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            _errors.AppendLine($"[Lexer Error] ({line}:{charPositionInLine + 1}): {msg}");
        }

        public void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            _errors.AppendLine($"[Parser Error] ({line}:{charPositionInLine + 1}): {msg}");
        }

        public string GetErrors()
        {
            return _errors.ToString();
        }
    }
}
