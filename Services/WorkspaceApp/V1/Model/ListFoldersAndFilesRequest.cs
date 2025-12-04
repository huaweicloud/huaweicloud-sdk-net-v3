using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListFoldersAndFilesRequest 
    {

        /// <summary>
        /// 用户名
        /// </summary>
        [SDKProperty("user_name", IsQuery = true)]
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 个人文件夹ID。(用户拥有多个文件夹时，如果不传个人文件夹id则选择最早创建的文件系统进行文件查询)
        /// </summary>
        [SDKProperty("cloud_storage_assignment_id", IsQuery = true)]
        [JsonProperty("cloud_storage_assignment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudStorageAssignmentId { get; set; }

        /// <summary>
        /// 查询文件夹路径
        /// </summary>
        [SDKProperty("folder_url", IsQuery = true)]
        [JsonProperty("folder_url", NullValueHandling = NullValueHandling.Ignore)]
        public string FolderUrl { get; set; }

        /// <summary>
        /// 指定一个标识符，从该标识符以后按文件名的字典顺序返回文件列表。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 列举文件系统的最大数目，返回的文件系统列表将是按照字典顺序的最多前 limit 个，默认取值为1000。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFoldersAndFilesRequest {\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  cloudStorageAssignmentId: ").Append(CloudStorageAssignmentId).Append("\n");
            sb.Append("  folderUrl: ").Append(FolderUrl).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFoldersAndFilesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFoldersAndFilesRequest input)
        {
            if (input == null) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.CloudStorageAssignmentId != input.CloudStorageAssignmentId || (this.CloudStorageAssignmentId != null && !this.CloudStorageAssignmentId.Equals(input.CloudStorageAssignmentId))) return false;
            if (this.FolderUrl != input.FolderUrl || (this.FolderUrl != null && !this.FolderUrl.Equals(input.FolderUrl))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.CloudStorageAssignmentId != null) hashCode = hashCode * 59 + this.CloudStorageAssignmentId.GetHashCode();
                if (this.FolderUrl != null) hashCode = hashCode * 59 + this.FolderUrl.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
