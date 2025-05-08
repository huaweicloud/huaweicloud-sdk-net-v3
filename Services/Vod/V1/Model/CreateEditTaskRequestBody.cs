using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateEditTaskRequestBody 
    {

        /// <summary>
        /// 编辑任务输入
        /// </summary>
        [JsonProperty("inputs", NullValueHandling = NullValueHandling.Ignore)]
        public List<EditMediaTaskInput> Inputs { get; set; }

        /// <summary>
        /// 输出文件名
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("editing_settings", NullValueHandling = NullValueHandling.Ignore)]
        public EditingSetting EditingSettings { get; set; }

        /// <summary>
        /// 回调地址
        /// </summary>
        [JsonProperty("callback_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 自定义上下文
        /// </summary>
        [JsonProperty("session_context", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionContext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public ObsInfo Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("media_process_task", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalObjectProcessReq MediaProcessTask { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateEditTaskRequestBody {\n");
            sb.Append("  inputs: ").Append(Inputs).Append("\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  editingSettings: ").Append(EditingSettings).Append("\n");
            sb.Append("  callbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  sessionContext: ").Append(SessionContext).Append("\n");
            sb.Append("  output: ").Append(Output).Append("\n");
            sb.Append("  mediaProcessTask: ").Append(MediaProcessTask).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateEditTaskRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateEditTaskRequestBody input)
        {
            if (input == null) return false;
            if (this.Inputs != input.Inputs || (this.Inputs != null && input.Inputs != null && !this.Inputs.SequenceEqual(input.Inputs))) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;
            if (this.EditingSettings != input.EditingSettings || (this.EditingSettings != null && !this.EditingSettings.Equals(input.EditingSettings))) return false;
            if (this.CallbackUrl != input.CallbackUrl || (this.CallbackUrl != null && !this.CallbackUrl.Equals(input.CallbackUrl))) return false;
            if (this.SessionContext != input.SessionContext || (this.SessionContext != null && !this.SessionContext.Equals(input.SessionContext))) return false;
            if (this.Output != input.Output || (this.Output != null && !this.Output.Equals(input.Output))) return false;
            if (this.MediaProcessTask != input.MediaProcessTask || (this.MediaProcessTask != null && !this.MediaProcessTask.Equals(input.MediaProcessTask))) return false;

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
                if (this.Inputs != null) hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.FileName != null) hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.EditingSettings != null) hashCode = hashCode * 59 + this.EditingSettings.GetHashCode();
                if (this.CallbackUrl != null) hashCode = hashCode * 59 + this.CallbackUrl.GetHashCode();
                if (this.SessionContext != null) hashCode = hashCode * 59 + this.SessionContext.GetHashCode();
                if (this.Output != null) hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.MediaProcessTask != null) hashCode = hashCode * 59 + this.MediaProcessTask.GetHashCode();
                return hashCode;
            }
        }
    }
}
