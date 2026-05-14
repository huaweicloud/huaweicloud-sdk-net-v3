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
    public class CreateAssetEditTaskReq 
    {

        /// <summary>
        /// 待编辑媒资列表，最多支持20个。 
        /// </summary>
        [JsonProperty("inputs", NullValueHandling = NullValueHandling.Ignore)]
        public List<EditInput> Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("editing_settings", NullValueHandling = NullValueHandling.Ignore)]
        public VodEditingSetting EditingSettings { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAssetEditTaskReq {\n");
            sb.Append("  inputs: ").Append(Inputs).Append("\n");
            sb.Append("  editingSettings: ").Append(EditingSettings).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAssetEditTaskReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAssetEditTaskReq input)
        {
            if (input == null) return false;
            if (this.Inputs != input.Inputs || (this.Inputs != null && input.Inputs != null && !this.Inputs.SequenceEqual(input.Inputs))) return false;
            if (this.EditingSettings != input.EditingSettings || (this.EditingSettings != null && !this.EditingSettings.Equals(input.EditingSettings))) return false;

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
                if (this.EditingSettings != null) hashCode = hashCode * 59 + this.EditingSettings.GetHashCode();
                return hashCode;
            }
        }
    }
}
