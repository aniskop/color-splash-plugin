/*
 * Created by SharpDevelop.
 * User: pavel
 * Date: 2015.03.03
 * Time: 18:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace ColorSplash
{
    /// <summary>
    /// Description of SampleCode.
    /// </summary>
    public sealed class SampleCode
    {
        private static SampleCode instance;
        
        private List<Token> keywords = null;
        private List<Token> comments = null;
        private List<Token> strings = null;
        private List<Token> numbers = null;
        private List<Token> delimiters = null;
        private List<Token> identifiers = null;
        
        private static string code =
            "/*\n" +
            " * This is a demo PL/SQL code snippet\n" +
            " * containing major tokens of PL/SQL language\n" +
            " * to test the color scheme of the editor.\n" +
            " */\n" +
            "CREATE OR REPLACE PACKAGE BODY MY_SCHEMA.MY_PACKAGE IS\n" +
            "  PROCEDURE SAY_SOMETHING(par_text  IN VARCHAR2,\n" +
            "                          par_times IN INTEGER := 1) IS\n" +
            "  BEGIN\n" +
            "    -- Say the text several times\n" +
            "    FOR I IN 1..par_times\n" +
            "    LOOP\n" +
            "      DBMS_OUTPUT.PUT_LINE(par_text);\n" +
            "    END LOOP;\n" +
            "  END;\n" +
            "  -- This function just returns something.\n" +
            "  -- It is for demo purposes only\n" +
            "  FUNCTION RETURN_SOMETHING RETURN VARCHAR2 IS\n" +
            "    message VARCHAR2(20);\n" +
            "    dummy   NUMBER;\n" +
            "  BEGIN\n" +
            "    dummy := 10 + 20;\n" +
            "    -- Just a comment\n" +
            "    message := 'First line of text';\n" +
            "    dummy := MOD(dummy, 3);\n" +
            "    RETURN message||'and dummy='||dummy;\n" +
            "  END;\n" +
            "END;\n" +
            "/\n";
        
        public static SampleCode Instance {
            get {
                if (instance == null) {
                    instance = new SampleCode();
                }
                return instance;
            }
        }
        
        private SampleCode()
        {
            SimplePlsqlParser parser = new SimplePlsqlParser();
            /* 
             * Make text upper because parser has got
             * keyword list in upper-case.
             * Token's position - is only valuable info got from parser.
             * The text ofthe token is never used.
             */
            parser.Parse(code.ToUpper());
            keywords = parser.Keywords;
            comments = parser.Comments;
            strings = parser.Strings;
            numbers = parser.Numbers;
            delimiters = parser.Delimiters;
            identifiers = parser.Identifiers;
        }
        
        public string Text {
            get { return code; }
        }
        
        
        public List<Token> Keywords {
            get { return keywords; }
        }
        
        public List<Token> Comments {
            get { return comments; }
        }

        public List<Token> Strings {
            get { return strings; }
        }

        public List<Token> Numbers {
            get { return numbers; }
        }

        public List<Token> Delimiters {
            get { return delimiters; }
        }

        public List<Token> Identifiers {
            get { return identifiers; }
        }
        
        public bool IsHighlighted(string text)
        {
            // Just highlight one keyword and identifier to see how it looks
            if ("DUMMY".Equals(text) || "FOR".Equals(text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
