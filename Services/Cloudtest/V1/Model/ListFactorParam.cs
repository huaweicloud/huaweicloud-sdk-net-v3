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
    public class ListFactorParam 
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
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("parent_node_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ParentNodeIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("creator_num", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mindmap_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MindmapId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("testpoint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TestpointId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mindmap_node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MindmapNodeId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFactorParam {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  parentNodeIds: ").Append(ParentNodeIds).Append("\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  creatorNum: ").Append(CreatorNum).Append("\n");
            sb.Append("  mindmapId: ").Append(MindmapId).Append("\n");
            sb.Append("  testpointId: ").Append(TestpointId).Append("\n");
            sb.Append("  mindmapNodeId: ").Append(MindmapNodeId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFactorParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFactorParam input)
        {
            if (input == null) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ParentNodeIds != input.ParentNodeIds || (this.ParentNodeIds != null && input.ParentNodeIds != null && !this.ParentNodeIds.SequenceEqual(input.ParentNodeIds))) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.CreatorNum != input.CreatorNum || (this.CreatorNum != null && !this.CreatorNum.Equals(input.CreatorNum))) return false;
            if (this.MindmapId != input.MindmapId || (this.MindmapId != null && !this.MindmapId.Equals(input.MindmapId))) return false;
            if (this.TestpointId != input.TestpointId || (this.TestpointId != null && !this.TestpointId.Equals(input.TestpointId))) return false;
            if (this.MindmapNodeId != input.MindmapNodeId || (this.MindmapNodeId != null && !this.MindmapNodeId.Equals(input.MindmapNodeId))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ParentNodeIds != null) hashCode = hashCode * 59 + this.ParentNodeIds.GetHashCode();
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.CreatorNum != null) hashCode = hashCode * 59 + this.CreatorNum.GetHashCode();
                if (this.MindmapId != null) hashCode = hashCode * 59 + this.MindmapId.GetHashCode();
                if (this.TestpointId != null) hashCode = hashCode * 59 + this.TestpointId.GetHashCode();
                if (this.MindmapNodeId != null) hashCode = hashCode * 59 + this.MindmapNodeId.GetHashCode();
                return hashCode;
            }
        }
    }
}
