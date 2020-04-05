/*
 * Created by SharpDevelop.
 * User: pavel
 * Date: 2015.03.03
 * Time: 21:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace ColorSplash
{
	/// <summary>
	/// Description of SimplePlsqlParser.
	/// </summary>
	public class SimplePlsqlParser
	{

		private static string[] keywords =
		{
			// Keywords
			"A", "ADD", "AGENT", "AGGREGATE", "ARRAY", "ATTRIBUTE", "AUTHID", "AVG",
			"BFILE_BASE", "BINARY", "BLOB_BASE", "BLOCK", "BODY", "BOTH", "BOUND", "BULK", "BYTE",
			"C", "CALL", "CALLING", "CASCADE", "CHAR", "CHAR_BASE", "CHARACTER", "CHARSETFORM", "CHARSETID",
			"CHARSET", "CLOB_BASE", "CLOSE", "COLLECT", "COMMENT", "COMMIT",
			"COMMITTED", "COMPILED", "CONSTANT", "CONSTRUCTOR", "CONTEXT", "CONVERT", "COUNT", "CURSOR", "CUSTOMDATUM",
			"DANGLING", "DATA", "DATE", "DATE_BASE", "DAY", "DEFINE", "DETERMINISTIC",
			"DOUBLE", "DURATION",
			"ELEMENT", "ELSIF", "EMPTY", "ESCAPE", "EXCEPT", "EXCEPTIONS", "EXECUTE", "EXIT", "EXTERNAL",
			"FINAL", "FIXED", "FLOAT", "FORALL", "FORCE", "FUNCTION", "GENERAL", "HASH", "HEAP", "HIDDEN", "HOUR",
			"IMMEDIATE", "INCLUDING", "INDICATOR", "INDICES", "INFINITE", "INSTANTIABLE", "INT", "INTEGER", "INTERFACE",
			"INTERVAL", "INVALIDATE", "ISOLATION", "JAVA",
			"LANGUAGE", "LARGE", "LEADING", "LENGTH", "LEVEL", "LIBRARY", "LIKE2",
			"LIKE4", "LIKEC", "LIMIT", "LIMITED", "LOCAL", "LONG", "LOOP",
			"MAP", "MAX", "MAXLEN", "MEMBER", "MERGE", "MIN", "MINUTE", "MOD", "MODIFY", "MONTH", "MULTISET",
			"NAME", "NAN", "NATIONAL", "NATIVE", "NCHAR", "NEW", "NOCOPY", "NUMBER", "NUMBER_BASE",
			"OBJECT", "OCICOLL", "OCIDATETIME", "OCIDATE", "OCIDURATION", "OCIINTERVAL", "OCILOBLOCATOR", "OCINUMBER",
			"OCIRAW", "OCIREFCURSOR", "OCIREF", "OCIROWID", "OCISTRING", "OCITYPE", "ONLY", "OPAQUE",
			"OPEN", "OPERATOR", "ORACLE", "ORADATA", "ORGANIZATION", "ORLANY", "ORLVARY", "OTHERS", "OUT", "OVERRIDING",
			"PACKAGE", "PARALLEL_ENABLE", "PARAMETER", "PARAMETERS", "PARTITION", "PASCAL", "PIPE",
			"PIPELINED", "PRAGMA", "PRECISION", "PRIVATE",
			"RAISE", "RANGE", "RAW", "READ", "RECORD", "REF", "REFERENCE", "REM",
			"REMAINDER", "RENAME", "REPLACE", "RESULT", "RETURN", "RETURNING", "REVERSE", "ROLLBACK", "ROW",
			"SAMPLE", "SAVE", "SAVEPOINT", "SB1", "SB2", "SB4", "SECOND", "SEGMENT",
			"SELF", "SEPARATE", "SEQUENCE", "SERIALIZABLE", "SET", "SHORT", "SIZE_T",
			"SOME", "SPARSE", "SQLCODE", "SQLDATA", "SQLNAME", "SQLSTATE", "STANDARD",
			"STATIC", "STDDEV", "STORED", "STRING", "STRUCT", "STYLE", "SUBMULTISET",
			"SUBPARTITION", "SUBSTITUTABLE", "SUBTYPE", "SUM", "SYNONYM",
			"TDO", "THE", "TIME", "TIMESTAMP", "TIMEZONE_ABBR", "TIMEZONE_HOUR", "TIMEZONE_MINUTE",
			"TIMEZONE_REGION", "TRAILING", "TRANSAC", "TRANSACTIONAL", "TRUSTED", "TYPE",
			"UB1", "UB2", "UB4", "UNDER", "UNSIGNED", "UNTRUSTED", "USE", "USING",
			"VALIST", "VALUE", "VARCHAR2", "VARIABLE", "VARIANCE", "VARRAY", "VARYING", "VOID",
			"WHILE", "WORK", "WRAPPED", "WRITE", "YEAR", "ZONE",
			// Reserved words
			"ALL", "ALTER", "AND", "ANY", "ARRAY", "ARROW", "AS", "ASC", "AT",
			"BEGIN", "BETWEEN", "BY", "CASE", "CHECK", "CLUSTERS", "CLUSTER",
			"COLAUTH", "COLUMNS", "COMPRESS", "CONNECT", "CRASH", "CREATE", "CURRENT",
			"DECIMAL", "DECLARE", "DEFAULT", "DELETE", "DESC", "DISTINCT", "DROP",
			"ELSE", "END", "EXCEPTION", "EXCLUSIVE", "EXISTS", "FETCH", "FORM",
			"FOR", "FROM", "GOTO", "GRANT", "GROUP", "HAVING", "IDENTIFIED", "IF",
			"IN", "INDEXES", "INDEX", "INSERT", "INTERSECT", "INTO", "IS", "LIKE", "LOCK",
			"MINUS", "MODE", "NOCOMPRESS", "NOT", "NOWAIT", "NULL", "OF", "ON", "OPTION",
			"OR", "ORDER", "OVERLAPS", "PRIOR", "PROCEDURE", "PUBLIC", "RANGE", "RECORD",
			"RESOURCE", "REVOKE", "SELECT", "SHARE", "SIZE", "SQL", "START", "SUBTYPE",
			"TABAUTH", "TABLE", "THEN", "TO", "TYPE", "UNION", "UNIQUE", "UPDATE",
			"USE", "VALUES", "VIEW", "VIEWS", "WHEN", "WHERE", "WITH"
		};
		/*
		 * Because it is simple parser just for coloring
		 * process only single-char delimiters. Two-char delimiters like >>
		 * are just 2 single-char delimiters: > and >.
		 * For coloring it is the same.
		 */
		private static string[] delimiters =
		{
			"+", "%", "'", ".", "/", "(", ")",
			":", ",", "*", "\"", "=", "<", ">",
			"@", ";", "-", "^", "~", "!",
			"|"
		};
		
		private List<Token> keywordTokens = null;
		private List<Token> commentTokens = null;
		private List<Token> stringTokens = null;
		private List<Token> numberTokens = null;
		private List<Token> delimiterTokens = null;
		private List<Token> identifierTokens = null;
		
		private const int UNDEFINED = -1;
		
		private int currentPos = UNDEFINED;

		public SimplePlsqlParser()
		{
		}
		
		#region Parse() method
		public void Parse(string text)
		{
			Reset();
			currentPos = 0;
			
			Token t = ReadToken(text);
			while (t != null)
			{
				if (IsKeyword(t))
				{
					AddKeyword(t);
				}
				else if (IsComment(t))
				{
					AddComment(t);
				}
				else if (IsString(t))
				{
					AddString(t);
				}
				else if (IsNumber(t))
				{
					AddNumber(t);
				}
				else if (IsDelimiter(t))
				{
					AddDelimiter(t);
				}
				else
				{
					AddIdentifier(t);
				}
				t = ReadToken(text);
			}
			
		}
		
		#endregion
		
		#region Parsing utility methods
		private void Reset() {
			currentPos = UNDEFINED;
			keywordTokens = new List<Token>();
			commentTokens = new List<Token>();
			stringTokens = new List<Token>();
			numberTokens = new List<Token>();
			delimiterTokens = new List<Token>();
			identifierTokens = new List<Token>();
		}
		
		private bool IsKeyword(Token t) {
			String s = t.Text;
			for (int i = 0; i < keywords.Length; i++) {
				if (s.Equals(keywords[i])) {
					return true;
				}
			}
			return false;
		}

		private bool IsDelimiter(string s) {
			for (int i = 0; i < delimiters.Length; i++) {
				if (s.Equals(delimiters[i])) {
					return true;
				}
			}
			return false;
		}
		
		private bool IsDelimiter(char s) {
			return IsDelimiter(Convert.ToString(s));
		}
		
		private bool IsDelimiter(Token t)
		{
			return IsDelimiter(t.Text);
		}
		
		private bool IsComment(Token t)
		{
			return CheckSinglelineComment(0, t.Text) || CheckMultilineComment(0, t.Text);
		}
		
		private bool IsString(Token t)
		{
			return CheckString(0, t.Text);
		}
		
		private bool IsNumber(Token t)
		{
			return CheckNumber(0, t.Text);
		}
		
		private void AddKeyword(Token t) {
			keywordTokens.Add(t);
		}

		private void AddIdentifier(Token t) {
			identifierTokens.Add(t);
		}
		
		private void AddDelimiter(Token t) {
			delimiterTokens.Add(t);
		}
		
		private void AddComment(Token t) {
			commentTokens.Add(t);
		}
		
		private void AddString(Token t)
		{
			stringTokens.Add(t);
		}
		
		private void AddNumber(Token t)
		{
			numberTokens.Add(t);
		}
		
		private bool IsMultilineComment(char c1, char c2)
		{
			if (c1 == '/' && c2 == '*')
			{
				return true;
			}
			return false;
		}
		
		/// <summary>
		/// Checks if PL/SQL single line comment starts at a given offset.
		/// </summary>
		/// <param name="offset">Offset from the beginning of the code.</param>
		/// <param name="code">Source code.</param>
		/// <returns></returns>
		private bool CheckSinglelineComment(int offset, string code)
		{
			/*
			 * If there are less than 2 characters left in a string
			 * there cannot be single line comment.
			 */
			if ((offset + 2) > code.Length)
			{
				return false;
			}
			
			if ((code[offset] == '-') && (code[offset + 1] == '-')) {
				return true;
			}
			return false;
		}
		
		private Token ReadSinglelineComment(int offset, string code)
		{
			// Read until end of line or end of code
			int end = code.IndexOf('\n', offset);
			if (end < 0)
			{
				end = code.Length;
			}
			return new Token(offset, code.Substring(offset, end - offset));
		}
		
		private int SkipWhitespaces(int offset, string code)
		{
			int i = offset;
			while (i < code.Length)
			{
				if (Char.IsWhiteSpace(code[i]))
				{
					i++;
				}
				else
				{
					break;
				}
			}
			return i;
		}

		private bool CheckMultilineComment(int offset, string code)
		{
			/*
			 * If there are less than 2 characters left in a string
			 * there cannot be multi line comment.
			 */
			if ((offset + 2) > code.Length)
			{
				return false;
			}
			
			if (code[offset] == '/' && code[offset + 1] == '*') {
				return true;
			}
			return false;
		}
		
		private Token ReadMultilineComment(int offset, string code)
		{
			// Read until end of comment or end of code
			int end = code.IndexOf("*/", offset);
			if (end < 0)
			{
				end = code.Length;
			}
			return new Token(offset, code.Substring(offset, end - offset + 2)); // +2 is length of "*/"
		}
		
		private bool CheckString(int offset, string code)
		{
			if (code[offset] == '\'')
			{
				return true;
			}
			return false;
		}
		
		private Token ReadString(int offset, string code)
		{
			int end  = code.IndexOf('\'', offset + 1);
			if (end < 0)
			{
				end = code.Length;
			}
			return new Token(offset, code.Substring(offset, end - offset + 1));
		}
		
		private bool CheckNumber(int offset, string code)
		{
			if (Char.IsNumber(code[offset]))
			{
				return true;
			}
			return false;
		}
		
		private Token ReadNumber(int offset, string code)
		{
			int i = offset;
			StringBuilder s = new StringBuilder();
			
			while (Char.IsNumber(code[i]))
			{
				s.Append(code[i]);
				i++;
				if (i >= code.Length)
				{
					break;
				}
			}
			return new Token(offset, s.ToString());
		}
		
		private Token ReadIdentifier(int offset, string code)
		{
			int i = offset;
			StringBuilder s = new StringBuilder();
			while (i < code.Length)
			{
				if (Char.IsWhiteSpace(code[i]) || IsDelimiter(code[i]))
				{
					break;
				}
				s.Append(code[i]);
				i++;
			}
			
			return new Token(offset, s.ToString());
		}
		
		private Token ReadToken(string code) {
			
			currentPos = SkipWhitespaces(currentPos, code);
			if (currentPos >= code.Length)
			{
				return null;
			}

			Token t = null;
			
			if (CheckSinglelineComment(currentPos, code))
			{
				t = ReadSinglelineComment(currentPos, code);
				// Set current position right after the comment
				currentPos += t.Length;
			}
			else if (CheckMultilineComment(currentPos, code))
			{
				t = ReadMultilineComment(currentPos, code);
				currentPos += t.Length;
			}
			else if (CheckString(currentPos, code))
			{
				t = ReadString(currentPos, code);
				currentPos += t.Length;
			}
			else if (CheckNumber(currentPos, code))
			{
				t = ReadNumber(currentPos, code);
				currentPos += t.Length;
			}
			else if (IsDelimiter(code[currentPos]))
			{
				t = new Token(currentPos, Char.ToString(code[currentPos]));
				currentPos += t.Length;
			}
			else
			{
				t = ReadIdentifier(currentPos, code);
				currentPos += t.Length;
			}

			
			// Entire code has been read
			return t;
		}
		
		#endregion
		
		public List<Token> Keywords {
			get { return keywordTokens; }
		}

		public List<Token> Comments {
			get { return commentTokens; }
		}

		public List<Token> Strings {
			get { return stringTokens; }
		}

		public List<Token> Numbers {
			get { return numberTokens; }
		}

		public List<Token> Delimiters {
			get { return delimiterTokens; }
		}

		public List<Token> Identifiers {
			get { return identifierTokens; }
		}
	}
}
