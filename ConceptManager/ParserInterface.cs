//-----------------------------------------------------------------------
// <copyright file="ParserInterface.cs" company="eBusiness Solutions">
//     Copyright (c) eBusiness Solutions. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ConceptManager
{
    // Stanford parser supplied references
    using edu.stanford.nlp.parser.lexparser;
    using edu.stanford.nlp.process;
    using edu.stanford.nlp.trees;
    using java.io;
    // Visual Studio supplied references
    using System.Collections.Generic;

    /// <summary>
    /// Encapsulates the interface to the Stanford Parser
    /// </summary>
    public class ParserInterface
    {
        /// <summary>
        /// The Stanford Parser
        /// </summary>
        private static LexicalizedParser lp;

        /// <summary>
        /// The Stanford Tokenizer -- tokenizes the words in a sentence
        /// </summary>
        private static TokenizerFactory tf;

       
        /// <summary>
        ///  Initializes a new instance of the <see cref="ParserInterface" /> class.
        /// </summary>
        public static void Initialize()
        {
            // Path to models extracted from `stanford-parser-3.4.0-models.jar`
            var jarRoot = @"C:\Users\jackm_000\Documents\My Software\Visual Studio 2013\Projects\ConceptConstructor\Models";
            var modelsDirectory = jarRoot + @"\edu\stanford\nlp\models";

            // Load english PCFG parser from file
            lp = LexicalizedParser.loadModel(modelsDirectory + @"\lexparser\englishPCFG.ser.gz");

            // Load the tokenizer
            tf = PTBTokenizer.factory(new CoreLabelTokenFactory(), string.Empty);
        }

        /// <summary>
        /// Invokes the parser and passes back the produced parse tree in three forms: the tree, a printed tree and the sentence's signature 
        /// </summary>
        /// <returns>A structure containing the parser's output</returns>
        public static ParserOutput DoParse(string s)
        {
            Tree t;
            string pt;
            var retVal = new ParserOutput();

            if (s == "")
            {
                return retVal;
            }

            t = parse(s);
            pt = toString(t);
            string signature = ModelBuilder.GetSentenceSignature(t);

            retVal.sentence = s;
            retVal.T = t;
            retVal.Items = ToItems(pt);
            retVal.Signature = signature;
            return retVal;
        }

        /// <summary>
        /// Performs the parse.
        /// </summary>
        /// <returns>The parse tree</returns>
        private static Tree parse(string s)
        {
            ModelBuilder.Initialize();

            var sent2Reader = new StringReader(s);
            var rawWords2 = tf.getTokenizer(sent2Reader).tokenize();
            sent2Reader.close();
            var tree2 = lp.apply(rawWords2);

            return tree2;
        }

        /// <summary>
        /// Decomposes a sentence's parse tree (in string VerbNumber) into a list of strings that, for example, can be used to display in a list box.
        /// </summary>
        /// <param name="s">The parse tree as a string</param>
        /// <returns>A list of strings</returns>
        private static List<string> ToItems(string s)
        {
            List<string> items = new List<string>();

            int strLength = s.Length;
            var beginIx = 0;
            var endIx = 0;

            while (beginIx < strLength)
            {
                endIx = s.IndexOf("\r\n", beginIx);
                items.Add(s.Substring(beginIx, endIx - beginIx));
                beginIx = endIx + 2;
            }

            return items;
        }

        /// <summary>
        /// Converts a sentence's parse tree into a string
        /// </summary>
        /// <param name="t">The parse tree</param>
        /// <returns>An indented string containing the tags and words</returns>
        private static string toString(Tree t)
        {
            return t.pennString();
        }

        /// <summary>
        /// The composite return value from a parse
        /// </summary>
        public struct ParserOutput
        {
            /// <summary>
            /// The sentence that is parsed
            /// </summary>
            public string sentence;

            /// <summary>
            /// The sentence's parse tree
            /// </summary>
            public Tree T;

            /// <summary>
            /// The tagged string representation of the sentence's parse tree
            /// </summary>
            public List<string> Items;

            /// <summary>
            /// The sentence's signature
            /// </summary>
            public string Signature;
        }
    }
}