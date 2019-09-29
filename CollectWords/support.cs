using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectWords
{
  internal class support
  {
    public void removecomment(int j, ref string line, ref bool isinmultilinecomment)
    {
      if (!string.IsNullOrEmpty(line))
      {
        int i;
        int k;
        if (isinmultilinecomment)
        {
          i = line.IndexOf(@"*/");
          if (i >= 0)
          {
            isinmultilinecomment = false;
            line = line.Remove(j, i - j + 2);
            removecomment(i + 2, ref line, ref isinmultilinecomment);
          }
          else
          {
            line = line.Remove(j);
          }
        }
        else
        {
          i = line.IndexOf(@"/*");
          if (i >= 0)
          {
            isinmultilinecomment = true;
            removecomment(i, ref line, ref isinmultilinecomment);
          }
        }

        //Remove single line comment
        k = line.IndexOf(@"//");
        if (k >= 0)
        {
          line = line.Remove(k);
        }
      }
    }
  }
}
