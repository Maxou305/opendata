using System.Collections.Generic;
using OpendataLibrary;

namespace OpendataTests
{
    public class FakeRequest : IAPI
    {
        public string GetResponse()
        {
            return "[{\"id\":\"SEM:0844\",\"name\":\"Grenoble,Champs-Elysées\",\"lon\":5.71025,\"lat\":45.17794,\"zone\":\"SEM_GENCHAMPSEL\",\"lines\":[\"SEM:12\"]},{\"id\":\"SEM:0846\",\"name\":\"Grenoble,Salengro\",\"lon\":5.70893,\"lat\":45.17557,\"zone\":\"SEM_GENSALENGRO\",\"lines\":[\"SEM:12\"]},{\"id\":\"SEM:0847\",\"name\":\"Grenoble,Salengro\",\"lon\":5.70887,\"lat\":45.17566,\"zone\":\"SEM_GENSALENGRO\",\"lines\":[\"SEM:12\"]}]";
        }
    }
}
