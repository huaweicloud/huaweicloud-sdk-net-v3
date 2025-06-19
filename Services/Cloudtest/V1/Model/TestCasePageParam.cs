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
    public class TestCasePageParam 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public string Deleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("id_collection", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IdCollection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mindmap_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MindmapId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("node_id_collection", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NodeIdCollection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("is_archive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsArchive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("case_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CaseName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("has_sub_mindmap", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasSubMindmap { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sub_mindmap_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SubMindmapId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestCasePageParam {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  deleted: ").Append(Deleted).Append("\n");
            sb.Append("  idCollection: ").Append(IdCollection).Append("\n");
            sb.Append("  mindmapId: ").Append(MindmapId).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  nodeIdCollection: ").Append(NodeIdCollection).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  isArchive: ").Append(IsArchive).Append("\n");
            sb.Append("  caseName: ").Append(CaseName).Append("\n");
            sb.Append("  hasSubMindmap: ").Append(HasSubMindmap).Append("\n");
            sb.Append("  subMindmapId: ").Append(SubMindmapId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestCasePageParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestCasePageParam input)
        {
            if (input == null) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Deleted != input.Deleted || (this.Deleted != null && !this.Deleted.Equals(input.Deleted))) return false;
            if (this.IdCollection != input.IdCollection || (this.IdCollection != null && input.IdCollection != null && !this.IdCollection.SequenceEqual(input.IdCollection))) return false;
            if (this.MindmapId != input.MindmapId || (this.MindmapId != null && !this.MindmapId.Equals(input.MindmapId))) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.NodeIdCollection != input.NodeIdCollection || (this.NodeIdCollection != null && input.NodeIdCollection != null && !this.NodeIdCollection.SequenceEqual(input.NodeIdCollection))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.IsArchive != input.IsArchive || (this.IsArchive != null && !this.IsArchive.Equals(input.IsArchive))) return false;
            if (this.CaseName != input.CaseName || (this.CaseName != null && !this.CaseName.Equals(input.CaseName))) return false;
            if (this.HasSubMindmap != input.HasSubMindmap || (this.HasSubMindmap != null && !this.HasSubMindmap.Equals(input.HasSubMindmap))) return false;
            if (this.SubMindmapId != input.SubMindmapId || (this.SubMindmapId != null && input.SubMindmapId != null && !this.SubMindmapId.SequenceEqual(input.SubMindmapId))) return false;

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
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Deleted != null) hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                if (this.IdCollection != null) hashCode = hashCode * 59 + this.IdCollection.GetHashCode();
                if (this.MindmapId != null) hashCode = hashCode * 59 + this.MindmapId.GetHashCode();
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.NodeIdCollection != null) hashCode = hashCode * 59 + this.NodeIdCollection.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.IsArchive != null) hashCode = hashCode * 59 + this.IsArchive.GetHashCode();
                if (this.CaseName != null) hashCode = hashCode * 59 + this.CaseName.GetHashCode();
                if (this.HasSubMindmap != null) hashCode = hashCode * 59 + this.HasSubMindmap.GetHashCode();
                if (this.SubMindmapId != null) hashCode = hashCode * 59 + this.SubMindmapId.GetHashCode();
                return hashCode;
            }
        }
    }
}
