using System.Data;

namespace DAO
{
    public class SearchDAO
    {
        private static volatile SearchDAO instance;
        public static SearchDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SearchDAO();
                return instance;
            }
        }
        private SearchDAO() { }
        public DataTable Search(string key)
        {
            string query = "exec tkNhanVien @tukhoa";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { key });
            return result;
        }
    }
}
