// Generator { Name = "SearchRowGenerator", Template = "ISearchRow" }

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    public partial class FileSearchRow: ISearchAdvancedRow, ISearchAdvancedRow<FileSearchRowBasic>
    {
        public FileSearchRowBasic GetBasic() => this.basic;

        SearchRowBasic ISearchAdvancedRow.GetBasic() => this.basic;

        public FileSearchRowBasic CreateBasic()
        {
            if (this.basic == null) this.basic = new FileSearchRowBasic();
            return this.basic;
        }

        ISearchAdvancedRow<FileSearchRowBasic> 
            ISearchAdvancedRow<FileSearchRowBasic>.CreateBasic(Action<FileSearchRowBasic> initializer) => this.CreateBasic(initializer);

        public FileSearchRow CreateBasic(Action<FileSearchRowBasic> initializer)
        {
            var basic = this.CreateBasic();
            initializer(basic);
            return this;
        }

        SearchRowBasic ISearchAdvancedRow.CreateBasic() => this.CreateBasic();

        public SearchRowBasic GetJoin(string joinName) => GetOrCreateJoin(this, joinName);

        public J GetJoin<J>(string joinName) where J: SearchRowBasic => (J)this.GetJoin(joinName);

        public SearchRowBasic CreateJoin(string joinName) => GetOrCreateJoin(this, joinName, true);

        public J CreateJoin<J>(string joinName) where J: SearchRowBasic => (J)this.CreateJoin(joinName);

        ISearchAdvancedRow<FileSearchRowBasic> 
            ISearchAdvancedRow<FileSearchRowBasic>.CreateJoin<J>(string joinName, Action<J> initializer) => this.CreateJoin(joinName, initializer);

        public FileSearchRow CreateJoin<J>(string joinName, Action<J> initializer) where J: SearchRowBasic
        {
            J join =  this.CreateJoin<J>(joinName);
            initializer(join);
            return this;
        }

        // public IEnumerable<SearchRowBasic> GetJoins()
        // {
        //    yield return this.basic;
      //      yield return this.shopperJoin;
      //      yield return this.userJoin;
        //}

        private static SearchRowBasic GetOrCreateJoin(FileSearchRow target, string joinName, bool createIfNull = false)
        {
            SearchRowBasic result;
            Func<SearchRowBasic> creator;

            switch (joinName)
            {
                case "basic":
                    result = target.basic;
                    creator = () => target.basic = new FileSearchRowBasic();
                    break;


                case "shopperJoin":
                    result = target.shopperJoin;
                    creator = () => target.shopperJoin = new CustomerSearchRowBasic();
                    break;
        
                case "userJoin":
                    result = target.userJoin;
                    creator = () => target.userJoin = new EmployeeSearchRowBasic();
                    break;
                        default:
                    throw new ArgumentException("FileSearchRow does not have a " + joinName);
            }

            if (createIfNull && result == null) result = creator();
            return result;
        }
    }
}