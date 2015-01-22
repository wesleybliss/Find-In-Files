using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindInFiles {

    class FileMatch {

        private string name;
        private long line;
        private long offset;
        private string path;
        private string sample;

        public FileMatch( string name, long line, long offset, string path, string sample ) {
            this.name = name;
            this.line = line;
            this.offset = offset;
            this.path = path;
            this.sample = sample;
        }

        public FileMatch( string path, long offset ) : this(
            path.Substring( path.LastIndexOf( "\\" ) + 1 ),
            -1, offset, path, null
        ) {}

        public string getName() { return name; }
        public long getLine() { return line; }
        public long getOffset() { return offset; }
        public string getPath() { return path; }
        public string getSample() { return sample; }

    } // class

}
