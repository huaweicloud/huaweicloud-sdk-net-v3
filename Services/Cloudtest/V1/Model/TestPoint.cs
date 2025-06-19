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
    /// 
    /// </summary>
    public class TestPoint 
    {

        /// <summary>
        /// app
        /// </summary>
        [JsonProperty("app", NullValueHandling = NullValueHandling.Ignore)]
        public string App { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 创建人名称
        /// </summary>
        [JsonProperty("creator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorName { get; set; }

        /// <summary>
        /// 创建人工号
        /// </summary>
        [JsonProperty("creator_num", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorNum { get; set; }

        /// <summary>
        /// 删除时间
        /// </summary>
        [JsonProperty("delete_time", NullValueHandling = NullValueHandling.Ignore)]
        public string DeleteTime { get; set; }

        /// <summary>
        /// 逻辑删除字段
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public string Deleted { get; set; }

        /// <summary>
        /// 分组id
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// id 主键
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 脑图id
        /// </summary>
        [JsonProperty("mindmap_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MindmapId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 节点id
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// 需求id
        /// </summary>
        [JsonProperty("requirement_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequirementId { get; set; }

        /// <summary>
        /// 需求名称
        /// </summary>
        [JsonProperty("requirement_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RequirementName { get; set; }

        /// <summary>
        /// 服务id
        /// </summary>
        [JsonProperty("service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 状体类型
        /// </summary>
        [JsonProperty("status_type", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusType { get; set; }

        /// <summary>
        /// tc数量
        /// </summary>
        [JsonProperty("tc_counts", NullValueHandling = NullValueHandling.Ignore)]
        public string TcCounts { get; set; }

        /// <summary>
        /// 测试用例
        /// </summary>
        [JsonProperty("test_cases", NullValueHandling = NullValueHandling.Ignore)]
        public string TestCases { get; set; }

        /// <summary>
        /// 更新人名称
        /// </summary>
        [JsonProperty("update_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateName { get; set; }

        /// <summary>
        /// 更新人工号
        /// </summary>
        [JsonProperty("update_num", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateNum { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestPoint {\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  creatorName: ").Append(CreatorName).Append("\n");
            sb.Append("  creatorNum: ").Append(CreatorNum).Append("\n");
            sb.Append("  deleteTime: ").Append(DeleteTime).Append("\n");
            sb.Append("  deleted: ").Append(Deleted).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  mindmapId: ").Append(MindmapId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  requirementId: ").Append(RequirementId).Append("\n");
            sb.Append("  requirementName: ").Append(RequirementName).Append("\n");
            sb.Append("  serviceId: ").Append(ServiceId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  statusType: ").Append(StatusType).Append("\n");
            sb.Append("  tcCounts: ").Append(TcCounts).Append("\n");
            sb.Append("  testCases: ").Append(TestCases).Append("\n");
            sb.Append("  updateName: ").Append(UpdateName).Append("\n");
            sb.Append("  updateNum: ").Append(UpdateNum).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestPoint);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestPoint input)
        {
            if (input == null) return false;
            if (this.App != input.App || (this.App != null && !this.App.Equals(input.App))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.CreatorName != input.CreatorName || (this.CreatorName != null && !this.CreatorName.Equals(input.CreatorName))) return false;
            if (this.CreatorNum != input.CreatorNum || (this.CreatorNum != null && !this.CreatorNum.Equals(input.CreatorNum))) return false;
            if (this.DeleteTime != input.DeleteTime || (this.DeleteTime != null && !this.DeleteTime.Equals(input.DeleteTime))) return false;
            if (this.Deleted != input.Deleted || (this.Deleted != null && !this.Deleted.Equals(input.Deleted))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.MindmapId != input.MindmapId || (this.MindmapId != null && !this.MindmapId.Equals(input.MindmapId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.RequirementId != input.RequirementId || (this.RequirementId != null && !this.RequirementId.Equals(input.RequirementId))) return false;
            if (this.RequirementName != input.RequirementName || (this.RequirementName != null && !this.RequirementName.Equals(input.RequirementName))) return false;
            if (this.ServiceId != input.ServiceId || (this.ServiceId != null && !this.ServiceId.Equals(input.ServiceId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.StatusType != input.StatusType || (this.StatusType != null && !this.StatusType.Equals(input.StatusType))) return false;
            if (this.TcCounts != input.TcCounts || (this.TcCounts != null && !this.TcCounts.Equals(input.TcCounts))) return false;
            if (this.TestCases != input.TestCases || (this.TestCases != null && !this.TestCases.Equals(input.TestCases))) return false;
            if (this.UpdateName != input.UpdateName || (this.UpdateName != null && !this.UpdateName.Equals(input.UpdateName))) return false;
            if (this.UpdateNum != input.UpdateNum || (this.UpdateNum != null && !this.UpdateNum.Equals(input.UpdateNum))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;

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
                if (this.App != null) hashCode = hashCode * 59 + this.App.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.CreatorName != null) hashCode = hashCode * 59 + this.CreatorName.GetHashCode();
                if (this.CreatorNum != null) hashCode = hashCode * 59 + this.CreatorNum.GetHashCode();
                if (this.DeleteTime != null) hashCode = hashCode * 59 + this.DeleteTime.GetHashCode();
                if (this.Deleted != null) hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MindmapId != null) hashCode = hashCode * 59 + this.MindmapId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.RequirementId != null) hashCode = hashCode * 59 + this.RequirementId.GetHashCode();
                if (this.RequirementName != null) hashCode = hashCode * 59 + this.RequirementName.GetHashCode();
                if (this.ServiceId != null) hashCode = hashCode * 59 + this.ServiceId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusType != null) hashCode = hashCode * 59 + this.StatusType.GetHashCode();
                if (this.TcCounts != null) hashCode = hashCode * 59 + this.TcCounts.GetHashCode();
                if (this.TestCases != null) hashCode = hashCode * 59 + this.TestCases.GetHashCode();
                if (this.UpdateName != null) hashCode = hashCode * 59 + this.UpdateName.GetHashCode();
                if (this.UpdateNum != null) hashCode = hashCode * 59 + this.UpdateNum.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }
    }
}
