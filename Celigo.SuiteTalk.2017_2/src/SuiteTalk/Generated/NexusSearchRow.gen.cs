// Generator { Name = "SearchRowGenerator", Template = "ISearchRow" }

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    public partial class NexusSearchRow: ISearchAdvancedRow, ISearchAdvancedRow<NexusSearchRowBasic>
    {
        public NexusSearchRowBasic GetBasic() => this.basic;

        SearchRowBasic ISearchAdvancedRow.GetBasic() => this.basic;

        public NexusSearchRowBasic CreateBasic()
        {
            if (this.basic == null) this.basic = new NexusSearchRowBasic();
            return this.basic;
        }

        ISearchAdvancedRow<NexusSearchRowBasic> 
            ISearchAdvancedRow<NexusSearchRowBasic>.CreateBasic(Action<NexusSearchRowBasic> initializer) => this.CreateBasic(initializer);

        public NexusSearchRow CreateBasic(Action<NexusSearchRowBasic> initializer)
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

        ISearchAdvancedRow<NexusSearchRowBasic> 
            ISearchAdvancedRow<NexusSearchRowBasic>.CreateJoin<J>(string joinName, Action<J> initializer) => this.CreateJoin(joinName, initializer);

        public NexusSearchRow CreateJoin<J>(string joinName, Action<J> initializer) where J: SearchRowBasic
        {
            J join =  this.CreateJoin<J>(joinName);
            initializer(join);
            return this;
        }

        // public IEnumerable<SearchRowBasic> GetJoins()
        // {
        //    yield return this.basic;
      //      yield return this.userJoin;
        //}

        private static SearchRowBasic GetOrCreateJoin(NexusSearchRow target, string joinName, bool createIfNull = false)
        {
            SearchRowBasic result;
            Func<SearchRowBasic> creator;

            switch (joinName)
            {
                case "basic":
                    result = target.basic;
                    creator = () => target.basic = new NexusSearchRowBasic();
                    break;


                case "userJoin":
                    result = target.userJoin;
                    creator = () => target.userJoin = new EmployeeSearchRowBasic();
                    break;
                        default:
                    throw new ArgumentException("NexusSearchRow does not have a " + joinName);
            }

            if (createIfNull && result == null) result = creator();
            return result;
        }
    }
}