using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 实际的数据类型：单个对象，集合 或 NULL
    /// </summary>
    public class IteratorVersionSummaryVo 
    {

        /// <summary>
        /// 资源URI
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public string Author { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 级别
        /// </summary>
        [JsonProperty("rank", NullValueHandling = NullValueHandling.Ignore)]
        public int? Rank { get; set; }

        /// <summary>
        /// 待测版本
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 处理者ID
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public string Creator { get; set; }

        /// <summary>
        /// 关联迭代
        /// </summary>
        [JsonProperty("iterations", NullValueHandling = NullValueHandling.Ignore)]
        public string Iterations { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 最后修改人
        /// </summary>
        [JsonProperty("last_modifier", NullValueHandling = NullValueHandling.Ignore)]
        public string LastModifier { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [JsonProperty("last_modified", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// 修改时间时间戳
        /// </summary>
        [JsonProperty("last_modified_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastModifiedTimestamp { get; set; }

        /// <summary>
        /// 最后变更时间
        /// </summary>
        [JsonProperty("last_change_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastChangeTime { get; set; }

        /// <summary>
        /// 版本URI
        /// </summary>
        [JsonProperty("version_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionUri { get; set; }

        /// <summary>
        /// 源资源URI
        /// </summary>
        [JsonProperty("origin_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginUri { get; set; }

        /// <summary>
        /// 父资源URI
        /// </summary>
        [JsonProperty("parent_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentUri { get; set; }

        /// <summary>
        /// 父资源路径
        /// </summary>
        [JsonProperty("parent_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentPath { get; set; }

        /// <summary>
        /// 创建版本URI
        /// </summary>
        [JsonProperty("creation_version_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string CreationVersionUri { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("creation_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// 创建时间时间戳
        /// </summary>
        [JsonProperty("creation_date_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreationDateTimestamp { get; set; }

        /// <summary>
        /// 创建人名称
        /// </summary>
        [JsonProperty("author_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 是否为Master分支
        /// </summary>
        [JsonProperty("is_master", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsMaster { get; set; }

        /// <summary>
        /// 是否为迭代
        /// </summary>
        [JsonProperty("is_iterator", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsIterator { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("plan_start_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? PlanStartDate { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("plan_end_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? PlanEndDate { get; set; }

        /// <summary>
        /// 微服务ID
        /// </summary>
        [JsonProperty("service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceId { get; set; }

        /// <summary>
        /// 微服务名
        /// </summary>
        [JsonProperty("service_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceName { get; set; }

        /// <summary>
        /// PBI ID
        /// </summary>
        [JsonProperty("pbi_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PbiId { get; set; }

        /// <summary>
        /// PBI信息
        /// </summary>
        [JsonProperty("pbi_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PbiName { get; set; }

        /// <summary>
        /// 计划ID
        /// </summary>
        [JsonProperty("plan_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanId { get; set; }

        /// <summary>
        /// 度量PBI ID
        /// </summary>
        [JsonProperty("metric_pbi_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricPbiIds { get; set; }

        /// <summary>
        /// 度量PBI名称
        /// </summary>
        [JsonProperty("metric_pbi_id_names", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricPbiIdNames { get; set; }

        /// <summary>
        /// 最后同步时间
        /// </summary>
        [JsonProperty("last_syn_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastSynDate { get; set; }

        /// <summary>
        /// 版本是否关闭
        /// </summary>
        [JsonProperty("is_closed", NullValueHandling = NullValueHandling.Ignore)]
        public string IsClosed { get; set; }

        /// <summary>
        /// 是否同步git库
        /// </summary>
        [JsonProperty("asyn_git", NullValueHandling = NullValueHandling.Ignore)]
        public string AsynGit { get; set; }

        /// <summary>
        /// schema编号
        /// </summary>
        [JsonProperty("schema_no", NullValueHandling = NullValueHandling.Ignore)]
        public int? SchemaNo { get; set; }

        /// <summary>
        /// 迭代实际完成时间
        /// </summary>
        [JsonProperty("finish_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FinishDate { get; set; }

        /// <summary>
        /// 处理者名称
        /// </summary>
        [JsonProperty("owner_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerName { get; set; }

        /// <summary>
        /// 创建人名称
        /// </summary>
        [JsonProperty("creator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorName { get; set; }

        /// <summary>
        /// 当前所处阶段
        /// </summary>
        [JsonProperty("current_stage", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentStage { get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [JsonProperty("service_types", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTypes { get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [JsonProperty("risk_rating", NullValueHandling = NullValueHandling.Ignore)]
        public int? RiskRating { get; set; }

        /// <summary>
        /// 风险描述
        /// </summary>
        [JsonProperty("risk_des", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskDes { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// pi的id
        /// </summary>
        [JsonProperty("pi_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PiId { get; set; }

        /// <summary>
        /// 计划开始时间
        /// </summary>
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// 计划开始时间时间戳
        /// </summary>
        [JsonProperty("start_date_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartDateTimestamp { get; set; }

        /// <summary>
        /// 计划结束时间
        /// </summary>
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }

        /// <summary>
        /// 计划结束时间时间戳
        /// </summary>
        [JsonProperty("end_date_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndDateTimestamp { get; set; }

        /// <summary>
        /// 实际开始时间
        /// </summary>
        [JsonProperty("actual_start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ActualStartDate { get; set; }

        /// <summary>
        /// 实际开始时间时间戳
        /// </summary>
        [JsonProperty("actual_start_date_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? ActualStartDateTimestamp { get; set; }

        /// <summary>
        /// 实际完成时间
        /// </summary>
        [JsonProperty("actual_end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ActualEndDate { get; set; }

        /// <summary>
        /// 实际开始时间时间戳
        /// </summary>
        [JsonProperty("actual_end_date_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? ActualEndDateTimestamp { get; set; }

        /// <summary>
        /// 是否超期
        /// </summary>
        [JsonProperty("is_expired", NullValueHandling = NullValueHandling.Ignore)]
        public string IsExpired { get; set; }

        /// <summary>
        /// 计划过期信息,空代表不超期，否则给出具体超期信息
        /// </summary>
        [JsonProperty("expired_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiredInfo { get; set; }

        /// <summary>
        /// 迭代计划，默认包含design,execute,report
        /// </summary>
        [JsonProperty("stages", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Stages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("design", NullValueHandling = NullValueHandling.Ignore)]
        public DesignSummaryVo Design { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("execute", NullValueHandling = NullValueHandling.Ignore)]
        public ExecuteSummaryVo Execute { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("report", NullValueHandling = NullValueHandling.Ignore)]
        public ReportSummaryVo Report { get; set; }

        /// <summary>
        /// 所属分支URI
        /// </summary>
        [JsonProperty("branch_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchUri { get; set; }

        /// <summary>
        /// 所属分支名称
        /// </summary>
        [JsonProperty("branch_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IteratorVersionSummaryVo {\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  author: ").Append(Author).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  rank: ").Append(Rank).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  creator: ").Append(Creator).Append("\n");
            sb.Append("  iterations: ").Append(Iterations).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  lastModifier: ").Append(LastModifier).Append("\n");
            sb.Append("  lastModified: ").Append(LastModified).Append("\n");
            sb.Append("  lastModifiedTimestamp: ").Append(LastModifiedTimestamp).Append("\n");
            sb.Append("  lastChangeTime: ").Append(LastChangeTime).Append("\n");
            sb.Append("  versionUri: ").Append(VersionUri).Append("\n");
            sb.Append("  originUri: ").Append(OriginUri).Append("\n");
            sb.Append("  parentUri: ").Append(ParentUri).Append("\n");
            sb.Append("  parentPath: ").Append(ParentPath).Append("\n");
            sb.Append("  creationVersionUri: ").Append(CreationVersionUri).Append("\n");
            sb.Append("  creationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  creationDateTimestamp: ").Append(CreationDateTimestamp).Append("\n");
            sb.Append("  authorName: ").Append(AuthorName).Append("\n");
            sb.Append("  comment: ").Append(Comment).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  isMaster: ").Append(IsMaster).Append("\n");
            sb.Append("  isIterator: ").Append(IsIterator).Append("\n");
            sb.Append("  planStartDate: ").Append(PlanStartDate).Append("\n");
            sb.Append("  planEndDate: ").Append(PlanEndDate).Append("\n");
            sb.Append("  serviceId: ").Append(ServiceId).Append("\n");
            sb.Append("  serviceName: ").Append(ServiceName).Append("\n");
            sb.Append("  pbiId: ").Append(PbiId).Append("\n");
            sb.Append("  pbiName: ").Append(PbiName).Append("\n");
            sb.Append("  planId: ").Append(PlanId).Append("\n");
            sb.Append("  metricPbiIds: ").Append(MetricPbiIds).Append("\n");
            sb.Append("  metricPbiIdNames: ").Append(MetricPbiIdNames).Append("\n");
            sb.Append("  lastSynDate: ").Append(LastSynDate).Append("\n");
            sb.Append("  isClosed: ").Append(IsClosed).Append("\n");
            sb.Append("  asynGit: ").Append(AsynGit).Append("\n");
            sb.Append("  schemaNo: ").Append(SchemaNo).Append("\n");
            sb.Append("  finishDate: ").Append(FinishDate).Append("\n");
            sb.Append("  ownerName: ").Append(OwnerName).Append("\n");
            sb.Append("  creatorName: ").Append(CreatorName).Append("\n");
            sb.Append("  currentStage: ").Append(CurrentStage).Append("\n");
            sb.Append("  serviceTypes: ").Append(ServiceTypes).Append("\n");
            sb.Append("  riskRating: ").Append(RiskRating).Append("\n");
            sb.Append("  riskDes: ").Append(RiskDes).Append("\n");
            sb.Append("  projectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  piId: ").Append(PiId).Append("\n");
            sb.Append("  startDate: ").Append(StartDate).Append("\n");
            sb.Append("  startDateTimestamp: ").Append(StartDateTimestamp).Append("\n");
            sb.Append("  endDate: ").Append(EndDate).Append("\n");
            sb.Append("  endDateTimestamp: ").Append(EndDateTimestamp).Append("\n");
            sb.Append("  actualStartDate: ").Append(ActualStartDate).Append("\n");
            sb.Append("  actualStartDateTimestamp: ").Append(ActualStartDateTimestamp).Append("\n");
            sb.Append("  actualEndDate: ").Append(ActualEndDate).Append("\n");
            sb.Append("  actualEndDateTimestamp: ").Append(ActualEndDateTimestamp).Append("\n");
            sb.Append("  isExpired: ").Append(IsExpired).Append("\n");
            sb.Append("  expiredInfo: ").Append(ExpiredInfo).Append("\n");
            sb.Append("  stages: ").Append(Stages).Append("\n");
            sb.Append("  design: ").Append(Design).Append("\n");
            sb.Append("  execute: ").Append(Execute).Append("\n");
            sb.Append("  report: ").Append(Report).Append("\n");
            sb.Append("  branchUri: ").Append(BranchUri).Append("\n");
            sb.Append("  branchName: ").Append(BranchName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IteratorVersionSummaryVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IteratorVersionSummaryVo input)
        {
            if (input == null) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Author != input.Author || (this.Author != null && !this.Author.Equals(input.Author))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Rank != input.Rank || (this.Rank != null && !this.Rank.Equals(input.Rank))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.Creator != input.Creator || (this.Creator != null && !this.Creator.Equals(input.Creator))) return false;
            if (this.Iterations != input.Iterations || (this.Iterations != null && !this.Iterations.Equals(input.Iterations))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.LastModifier != input.LastModifier || (this.LastModifier != null && !this.LastModifier.Equals(input.LastModifier))) return false;
            if (this.LastModified != input.LastModified || (this.LastModified != null && !this.LastModified.Equals(input.LastModified))) return false;
            if (this.LastModifiedTimestamp != input.LastModifiedTimestamp || (this.LastModifiedTimestamp != null && !this.LastModifiedTimestamp.Equals(input.LastModifiedTimestamp))) return false;
            if (this.LastChangeTime != input.LastChangeTime || (this.LastChangeTime != null && !this.LastChangeTime.Equals(input.LastChangeTime))) return false;
            if (this.VersionUri != input.VersionUri || (this.VersionUri != null && !this.VersionUri.Equals(input.VersionUri))) return false;
            if (this.OriginUri != input.OriginUri || (this.OriginUri != null && !this.OriginUri.Equals(input.OriginUri))) return false;
            if (this.ParentUri != input.ParentUri || (this.ParentUri != null && !this.ParentUri.Equals(input.ParentUri))) return false;
            if (this.ParentPath != input.ParentPath || (this.ParentPath != null && !this.ParentPath.Equals(input.ParentPath))) return false;
            if (this.CreationVersionUri != input.CreationVersionUri || (this.CreationVersionUri != null && !this.CreationVersionUri.Equals(input.CreationVersionUri))) return false;
            if (this.CreationDate != input.CreationDate || (this.CreationDate != null && !this.CreationDate.Equals(input.CreationDate))) return false;
            if (this.CreationDateTimestamp != input.CreationDateTimestamp || (this.CreationDateTimestamp != null && !this.CreationDateTimestamp.Equals(input.CreationDateTimestamp))) return false;
            if (this.AuthorName != input.AuthorName || (this.AuthorName != null && !this.AuthorName.Equals(input.AuthorName))) return false;
            if (this.Comment != input.Comment || (this.Comment != null && !this.Comment.Equals(input.Comment))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.IsMaster != input.IsMaster || (this.IsMaster != null && !this.IsMaster.Equals(input.IsMaster))) return false;
            if (this.IsIterator != input.IsIterator || (this.IsIterator != null && !this.IsIterator.Equals(input.IsIterator))) return false;
            if (this.PlanStartDate != input.PlanStartDate || (this.PlanStartDate != null && !this.PlanStartDate.Equals(input.PlanStartDate))) return false;
            if (this.PlanEndDate != input.PlanEndDate || (this.PlanEndDate != null && !this.PlanEndDate.Equals(input.PlanEndDate))) return false;
            if (this.ServiceId != input.ServiceId || (this.ServiceId != null && !this.ServiceId.Equals(input.ServiceId))) return false;
            if (this.ServiceName != input.ServiceName || (this.ServiceName != null && !this.ServiceName.Equals(input.ServiceName))) return false;
            if (this.PbiId != input.PbiId || (this.PbiId != null && !this.PbiId.Equals(input.PbiId))) return false;
            if (this.PbiName != input.PbiName || (this.PbiName != null && !this.PbiName.Equals(input.PbiName))) return false;
            if (this.PlanId != input.PlanId || (this.PlanId != null && !this.PlanId.Equals(input.PlanId))) return false;
            if (this.MetricPbiIds != input.MetricPbiIds || (this.MetricPbiIds != null && !this.MetricPbiIds.Equals(input.MetricPbiIds))) return false;
            if (this.MetricPbiIdNames != input.MetricPbiIdNames || (this.MetricPbiIdNames != null && !this.MetricPbiIdNames.Equals(input.MetricPbiIdNames))) return false;
            if (this.LastSynDate != input.LastSynDate || (this.LastSynDate != null && !this.LastSynDate.Equals(input.LastSynDate))) return false;
            if (this.IsClosed != input.IsClosed || (this.IsClosed != null && !this.IsClosed.Equals(input.IsClosed))) return false;
            if (this.AsynGit != input.AsynGit || (this.AsynGit != null && !this.AsynGit.Equals(input.AsynGit))) return false;
            if (this.SchemaNo != input.SchemaNo || (this.SchemaNo != null && !this.SchemaNo.Equals(input.SchemaNo))) return false;
            if (this.FinishDate != input.FinishDate || (this.FinishDate != null && !this.FinishDate.Equals(input.FinishDate))) return false;
            if (this.OwnerName != input.OwnerName || (this.OwnerName != null && !this.OwnerName.Equals(input.OwnerName))) return false;
            if (this.CreatorName != input.CreatorName || (this.CreatorName != null && !this.CreatorName.Equals(input.CreatorName))) return false;
            if (this.CurrentStage != input.CurrentStage || (this.CurrentStage != null && !this.CurrentStage.Equals(input.CurrentStage))) return false;
            if (this.ServiceTypes != input.ServiceTypes || (this.ServiceTypes != null && !this.ServiceTypes.Equals(input.ServiceTypes))) return false;
            if (this.RiskRating != input.RiskRating || (this.RiskRating != null && !this.RiskRating.Equals(input.RiskRating))) return false;
            if (this.RiskDes != input.RiskDes || (this.RiskDes != null && !this.RiskDes.Equals(input.RiskDes))) return false;
            if (this.ProjectUuid != input.ProjectUuid || (this.ProjectUuid != null && !this.ProjectUuid.Equals(input.ProjectUuid))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.PiId != input.PiId || (this.PiId != null && !this.PiId.Equals(input.PiId))) return false;
            if (this.StartDate != input.StartDate || (this.StartDate != null && !this.StartDate.Equals(input.StartDate))) return false;
            if (this.StartDateTimestamp != input.StartDateTimestamp || (this.StartDateTimestamp != null && !this.StartDateTimestamp.Equals(input.StartDateTimestamp))) return false;
            if (this.EndDate != input.EndDate || (this.EndDate != null && !this.EndDate.Equals(input.EndDate))) return false;
            if (this.EndDateTimestamp != input.EndDateTimestamp || (this.EndDateTimestamp != null && !this.EndDateTimestamp.Equals(input.EndDateTimestamp))) return false;
            if (this.ActualStartDate != input.ActualStartDate || (this.ActualStartDate != null && !this.ActualStartDate.Equals(input.ActualStartDate))) return false;
            if (this.ActualStartDateTimestamp != input.ActualStartDateTimestamp || (this.ActualStartDateTimestamp != null && !this.ActualStartDateTimestamp.Equals(input.ActualStartDateTimestamp))) return false;
            if (this.ActualEndDate != input.ActualEndDate || (this.ActualEndDate != null && !this.ActualEndDate.Equals(input.ActualEndDate))) return false;
            if (this.ActualEndDateTimestamp != input.ActualEndDateTimestamp || (this.ActualEndDateTimestamp != null && !this.ActualEndDateTimestamp.Equals(input.ActualEndDateTimestamp))) return false;
            if (this.IsExpired != input.IsExpired || (this.IsExpired != null && !this.IsExpired.Equals(input.IsExpired))) return false;
            if (this.ExpiredInfo != input.ExpiredInfo || (this.ExpiredInfo != null && !this.ExpiredInfo.Equals(input.ExpiredInfo))) return false;
            if (this.Stages != input.Stages || (this.Stages != null && input.Stages != null && !this.Stages.SequenceEqual(input.Stages))) return false;
            if (this.Design != input.Design || (this.Design != null && !this.Design.Equals(input.Design))) return false;
            if (this.Execute != input.Execute || (this.Execute != null && !this.Execute.Equals(input.Execute))) return false;
            if (this.Report != input.Report || (this.Report != null && !this.Report.Equals(input.Report))) return false;
            if (this.BranchUri != input.BranchUri || (this.BranchUri != null && !this.BranchUri.Equals(input.BranchUri))) return false;
            if (this.BranchName != input.BranchName || (this.BranchName != null && !this.BranchName.Equals(input.BranchName))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.Uri != null) hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Author != null) hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Rank != null) hashCode = hashCode * 59 + this.Rank.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Creator != null) hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.Iterations != null) hashCode = hashCode * 59 + this.Iterations.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.LastModifier != null) hashCode = hashCode * 59 + this.LastModifier.GetHashCode();
                if (this.LastModified != null) hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.LastModifiedTimestamp != null) hashCode = hashCode * 59 + this.LastModifiedTimestamp.GetHashCode();
                if (this.LastChangeTime != null) hashCode = hashCode * 59 + this.LastChangeTime.GetHashCode();
                if (this.VersionUri != null) hashCode = hashCode * 59 + this.VersionUri.GetHashCode();
                if (this.OriginUri != null) hashCode = hashCode * 59 + this.OriginUri.GetHashCode();
                if (this.ParentUri != null) hashCode = hashCode * 59 + this.ParentUri.GetHashCode();
                if (this.ParentPath != null) hashCode = hashCode * 59 + this.ParentPath.GetHashCode();
                if (this.CreationVersionUri != null) hashCode = hashCode * 59 + this.CreationVersionUri.GetHashCode();
                if (this.CreationDate != null) hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.CreationDateTimestamp != null) hashCode = hashCode * 59 + this.CreationDateTimestamp.GetHashCode();
                if (this.AuthorName != null) hashCode = hashCode * 59 + this.AuthorName.GetHashCode();
                if (this.Comment != null) hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.IsMaster != null) hashCode = hashCode * 59 + this.IsMaster.GetHashCode();
                if (this.IsIterator != null) hashCode = hashCode * 59 + this.IsIterator.GetHashCode();
                if (this.PlanStartDate != null) hashCode = hashCode * 59 + this.PlanStartDate.GetHashCode();
                if (this.PlanEndDate != null) hashCode = hashCode * 59 + this.PlanEndDate.GetHashCode();
                if (this.ServiceId != null) hashCode = hashCode * 59 + this.ServiceId.GetHashCode();
                if (this.ServiceName != null) hashCode = hashCode * 59 + this.ServiceName.GetHashCode();
                if (this.PbiId != null) hashCode = hashCode * 59 + this.PbiId.GetHashCode();
                if (this.PbiName != null) hashCode = hashCode * 59 + this.PbiName.GetHashCode();
                if (this.PlanId != null) hashCode = hashCode * 59 + this.PlanId.GetHashCode();
                if (this.MetricPbiIds != null) hashCode = hashCode * 59 + this.MetricPbiIds.GetHashCode();
                if (this.MetricPbiIdNames != null) hashCode = hashCode * 59 + this.MetricPbiIdNames.GetHashCode();
                if (this.LastSynDate != null) hashCode = hashCode * 59 + this.LastSynDate.GetHashCode();
                if (this.IsClosed != null) hashCode = hashCode * 59 + this.IsClosed.GetHashCode();
                if (this.AsynGit != null) hashCode = hashCode * 59 + this.AsynGit.GetHashCode();
                if (this.SchemaNo != null) hashCode = hashCode * 59 + this.SchemaNo.GetHashCode();
                if (this.FinishDate != null) hashCode = hashCode * 59 + this.FinishDate.GetHashCode();
                if (this.OwnerName != null) hashCode = hashCode * 59 + this.OwnerName.GetHashCode();
                if (this.CreatorName != null) hashCode = hashCode * 59 + this.CreatorName.GetHashCode();
                if (this.CurrentStage != null) hashCode = hashCode * 59 + this.CurrentStage.GetHashCode();
                if (this.ServiceTypes != null) hashCode = hashCode * 59 + this.ServiceTypes.GetHashCode();
                if (this.RiskRating != null) hashCode = hashCode * 59 + this.RiskRating.GetHashCode();
                if (this.RiskDes != null) hashCode = hashCode * 59 + this.RiskDes.GetHashCode();
                if (this.ProjectUuid != null) hashCode = hashCode * 59 + this.ProjectUuid.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.PiId != null) hashCode = hashCode * 59 + this.PiId.GetHashCode();
                if (this.StartDate != null) hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.StartDateTimestamp != null) hashCode = hashCode * 59 + this.StartDateTimestamp.GetHashCode();
                if (this.EndDate != null) hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.EndDateTimestamp != null) hashCode = hashCode * 59 + this.EndDateTimestamp.GetHashCode();
                if (this.ActualStartDate != null) hashCode = hashCode * 59 + this.ActualStartDate.GetHashCode();
                if (this.ActualStartDateTimestamp != null) hashCode = hashCode * 59 + this.ActualStartDateTimestamp.GetHashCode();
                if (this.ActualEndDate != null) hashCode = hashCode * 59 + this.ActualEndDate.GetHashCode();
                if (this.ActualEndDateTimestamp != null) hashCode = hashCode * 59 + this.ActualEndDateTimestamp.GetHashCode();
                if (this.IsExpired != null) hashCode = hashCode * 59 + this.IsExpired.GetHashCode();
                if (this.ExpiredInfo != null) hashCode = hashCode * 59 + this.ExpiredInfo.GetHashCode();
                if (this.Stages != null) hashCode = hashCode * 59 + this.Stages.GetHashCode();
                if (this.Design != null) hashCode = hashCode * 59 + this.Design.GetHashCode();
                if (this.Execute != null) hashCode = hashCode * 59 + this.Execute.GetHashCode();
                if (this.Report != null) hashCode = hashCode * 59 + this.Report.GetHashCode();
                if (this.BranchUri != null) hashCode = hashCode * 59 + this.BranchUri.GetHashCode();
                if (this.BranchName != null) hashCode = hashCode * 59 + this.BranchName.GetHashCode();
                return hashCode;
            }
        }
    }
}
