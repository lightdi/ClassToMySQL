using System;
using System.Collections.Generic;
using System.Text;

namespace gData.Tests
{
    class MockFactory
    {
        public long Id { get; set; }
        public int mInt { get; set; }
        public string mVarChar { get; set; }
        public double mDouble { get; set; }
        public long  mLongId { get; set; }
        public string mBlob { get; set; }
        public DateTime mDate { get; set; }
        public DateTime mDateTime { get; set; }
        public DateTime mTimeStamp { get; set; }
        public MyEnum mEnum { get; set; }
        
        

    }

enum MyEnum
{
    Y, N

}
}
