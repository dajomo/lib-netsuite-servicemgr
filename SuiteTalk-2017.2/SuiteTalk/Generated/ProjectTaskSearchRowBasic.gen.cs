//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class ProjectTaskSearchRowBasic
    {
        // TODO: Make this Lazy and Weak referenced so that it can be garbaged collected
        private static readonly Lazy<ColumnFactory> columnFactoryLoader = new Lazy<ColumnFactory>(() => new ColumnFactory());

        public override void SetColumns(string[] columnNames)
        {
            var factory = columnFactoryLoader.Value;
            for (int i = 0; i < columnNames.Length; i++)
            {
                factory.BuildColumn(this, columnNames[i]);
            }
        }

        class ColumnFactory:  ColumnFactory<ProjectTaskSearchRowBasic>
        {
            protected override Dictionary<string, Action<ProjectTaskSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<ProjectTaskSearchRowBasic>> {
                    { "actualWork", r => r.@actualWork = new [] { new SearchColumnDoubleField { customLabel = "actualWork" } } },
                    { "company", r => r.@company = new [] { new SearchColumnSelectField { customLabel = "company" } } },
                    { "constraintType", r => r.@constraintType = new [] { new SearchColumnEnumSelectField { customLabel = "constraintType" } } },
                    { "contact", r => r.@contact = new [] { new SearchColumnSelectField { customLabel = "contact" } } },
                    { "cost", r => r.@cost = new [] { new SearchColumnDoubleField { customLabel = "cost" } } },
                    { "costBase", r => r.@costBase = new [] { new SearchColumnDoubleField { customLabel = "costBase" } } },
                    { "costBaseBaseline", r => r.@costBaseBaseline = new [] { new SearchColumnDoubleField { customLabel = "costBaseBaseline" } } },
                    { "costBaseline", r => r.@costBaseline = new [] { new SearchColumnDoubleField { customLabel = "costBaseline" } } },
                    { "costBaseVariance", r => r.@costBaseVariance = new [] { new SearchColumnDoubleField { customLabel = "costBaseVariance" } } },
                    { "costVariance", r => r.@costVariance = new [] { new SearchColumnDoubleField { customLabel = "costVariance" } } },
                    { "costVariancePercent", r => r.@costVariancePercent = new [] { new SearchColumnDoubleField { customLabel = "costVariancePercent" } } },
                    { "createdDate", r => r.@createdDate = new [] { new SearchColumnDateField { customLabel = "createdDate" } } },
                    { "endDate", r => r.@endDate = new [] { new SearchColumnDateField { customLabel = "endDate" } } },
                    { "endDateBaseline", r => r.@endDateBaseline = new [] { new SearchColumnDateField { customLabel = "endDateBaseline" } } },
                    { "endDateVariance", r => r.@endDateVariance = new [] { new SearchColumnDoubleField { customLabel = "endDateVariance" } } },
                    { "estimatedWork", r => r.@estimatedWork = new [] { new SearchColumnDoubleField { customLabel = "estimatedWork" } } },
                    { "estimatedWorkBaseline", r => r.@estimatedWorkBaseline = new [] { new SearchColumnDoubleField { customLabel = "estimatedWorkBaseline" } } },
                    { "estimatedWorkVariance", r => r.@estimatedWorkVariance = new [] { new SearchColumnDoubleField { customLabel = "estimatedWorkVariance" } } },
                    { "estimatedWorkVariancePercent", r => r.@estimatedWorkVariancePercent = new [] { new SearchColumnDoubleField { customLabel = "estimatedWorkVariancePercent" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "finishByDate", r => r.@finishByDate = new [] { new SearchColumnDateField { customLabel = "finishByDate" } } },
                    { "id", r => r.@id = new [] { new SearchColumnLongField { customLabel = "id" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "isMilestone", r => r.@isMilestone = new [] { new SearchColumnBooleanField { customLabel = "isMilestone" } } },
                    { "isSummaryTask", r => r.@isSummaryTask = new [] { new SearchColumnBooleanField { customLabel = "isSummaryTask" } } },
                    { "lastModifiedDate", r => r.@lastModifiedDate = new [] { new SearchColumnDateField { customLabel = "lastModifiedDate" } } },
                    { "message", r => r.@message = new [] { new SearchColumnStringField { customLabel = "message" } } },
                    { "nonBillableTask", r => r.@nonBillableTask = new [] { new SearchColumnBooleanField { customLabel = "nonBillableTask" } } },
                    { "owner", r => r.@owner = new [] { new SearchColumnSelectField { customLabel = "owner" } } },
                    { "parent", r => r.@parent = new [] { new SearchColumnSelectField { customLabel = "parent" } } },
                    { "percentWorkComplete", r => r.@percentWorkComplete = new [] { new SearchColumnDoubleField { customLabel = "percentWorkComplete" } } },
                    { "predecessor", r => r.@predecessor = new [] { new SearchColumnSelectField { customLabel = "predecessor" } } },
                    { "predecessorLagDays", r => r.@predecessorLagDays = new [] { new SearchColumnDoubleField { customLabel = "predecessorLagDays" } } },
                    { "predecessors", r => r.@predecessors = new [] { new SearchColumnStringField { customLabel = "predecessors" } } },
                    { "predecessorType", r => r.@predecessorType = new [] { new SearchColumnStringField { customLabel = "predecessorType" } } },
                    { "priority", r => r.@priority = new [] { new SearchColumnEnumSelectField { customLabel = "priority" } } },
                    { "remainingWork", r => r.@remainingWork = new [] { new SearchColumnDoubleField { customLabel = "remainingWork" } } },
                    { "startDate", r => r.@startDate = new [] { new SearchColumnDateField { customLabel = "startDate" } } },
                    { "startDateBaseline", r => r.@startDateBaseline = new [] { new SearchColumnDateField { customLabel = "startDateBaseline" } } },
                    { "startDateVariance", r => r.@startDateVariance = new [] { new SearchColumnDoubleField { customLabel = "startDateVariance" } } },
                    { "status", r => r.@status = new [] { new SearchColumnEnumSelectField { customLabel = "status" } } },
                    { "successor", r => r.@successor = new [] { new SearchColumnSelectField { customLabel = "successor" } } },
                    { "successorType", r => r.@successorType = new [] { new SearchColumnStringField { customLabel = "successorType" } } },
                    { "title", r => r.@title = new [] { new SearchColumnStringField { customLabel = "title" } } },
                };
            }
        }
    }
}