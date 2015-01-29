using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindInFiles {

    class FileMatch {

        private string name;
        private int line;
        private int offset;
        private string path;
        private string sample;

        public FileMatch( string name, int line, int offset, string path, string sample ) {
            this.name = name;
            this.line = line;
            this.offset = offset;
            this.path = path;
            this.sample = sample;
        }

        public FileMatch( string path, int offset ) : this(
            path.Substring( path.LastIndexOf( "\\" ) + 1 ),
            -1, offset, path, null
        ) {}

        public string getName() { return name; }
        public int getLine() { return line; }
        public int getOffset() { return offset; }
        public string getPath() { return path; }
        public string getSample() { return sample; }

    } // class

}
