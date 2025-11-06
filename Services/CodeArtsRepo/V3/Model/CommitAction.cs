using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CommitAction 
    {

        /// <summary>
        /// 要执行的操作：create、delete、move、update、chmod
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// 文件的完整路径。例如lib/class.rb
        /// </summary>
        [JsonProperty("file_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FilePath { get; set; }

        /// <summary>
        /// 要移动的文件的原始完整路径。例如lib/class1.rb。仅在move操作时生效
        /// </summary>
        [JsonProperty("previous_path", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousPath { get; set; }

        /// <summary>
        /// 文件内容，create和update操作时必须。未指定内容的移动操作将保留现有文件内容，内容的任何其他值将覆盖文件内容。
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// 文件编码：text、base64。默认为text
        /// </summary>
        [JsonProperty("encoding", NullValueHandling = NullValueHandling.Ignore)]
        public string Encoding { get; set; }

        /// <summary>
        /// 最后一个已知的提交ID。仅在update、move、delete操作时生效
        /// </summary>
        [JsonProperty("last_commit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LastCommitId { get; set; }

        /// <summary>
        /// 启用或者禁用文件的执行模式。仅在chmod操作时生效
        /// </summary>
        [JsonProperty("execute_filemode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExecuteFilemode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommitAction {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  filePath: ").Append(FilePath).Append("\n");
            sb.Append("  previousPath: ").Append(PreviousPath).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("  encoding: ").Append(Encoding).Append("\n");
            sb.Append("  lastCommitId: ").Append(LastCommitId).Append("\n");
            sb.Append("  executeFilemode: ").Append(ExecuteFilemode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CommitAction);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CommitAction input)
        {
            if (input == null) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.FilePath != input.FilePath || (this.FilePath != null && !this.FilePath.Equals(input.FilePath))) return false;
            if (this.PreviousPath != input.PreviousPath || (this.PreviousPath != null && !this.PreviousPath.Equals(input.PreviousPath))) return false;
            if (this.Content != input.Content || (this.Content != null && !this.Content.Equals(input.Content))) return false;
            if (this.Encoding != input.Encoding || (this.Encoding != null && !this.Encoding.Equals(input.Encoding))) return false;
            if (this.LastCommitId != input.LastCommitId || (this.LastCommitId != null && !this.LastCommitId.Equals(input.LastCommitId))) return false;
            if (this.ExecuteFilemode != input.ExecuteFilemode || (this.ExecuteFilemode != null && !this.ExecuteFilemode.Equals(input.ExecuteFilemode))) return false;

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
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.FilePath != null) hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.PreviousPath != null) hashCode = hashCode * 59 + this.PreviousPath.GetHashCode();
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Encoding != null) hashCode = hashCode * 59 + this.Encoding.GetHashCode();
                if (this.LastCommitId != null) hashCode = hashCode * 59 + this.LastCommitId.GetHashCode();
                if (this.ExecuteFilemode != null) hashCode = hashCode * 59 + this.ExecuteFilemode.GetHashCode();
                return hashCode;
            }
        }
    }
}
