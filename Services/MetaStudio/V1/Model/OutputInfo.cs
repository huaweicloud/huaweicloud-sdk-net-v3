using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 输出信息。
    /// </summary>
    public class OutputInfo 
    {

        /// <summary>
        /// 面部表情输入地址。
        /// </summary>
        [JsonProperty("face_addr", NullValueHandling = NullValueHandling.Ignore)]
        public string FaceAddr { get; set; }

        /// <summary>
        /// 身体动作输入地址。
        /// </summary>
        [JsonProperty("body_addr", NullValueHandling = NullValueHandling.Ignore)]
        public string BodyAddr { get; set; }

        /// <summary>
        /// 音频输入地址。
        /// </summary>
        [JsonProperty("audio_addr", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioAddr { get; set; }

        /// <summary>
        /// 会话ID。
        /// </summary>
        [JsonProperty("session_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SessionId { get; set; }

        /// <summary>
        /// 输出数据的格式版本，如请求中无此参数，则输出数据格式为1.0，可选值有： 1.0: 对应的输出为：         动作数据：75个骨骼旋转值         表情数据：52ARkit表情及参数 2.0: 对应的输出为：         动作数据：55个骨骼旋转值+骨骼3D坐标         表情数据：178个控制器的数据
        /// </summary>
        [JsonProperty("output_data_version", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputDataVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutputInfo {\n");
            sb.Append("  faceAddr: ").Append(FaceAddr).Append("\n");
            sb.Append("  bodyAddr: ").Append(BodyAddr).Append("\n");
            sb.Append("  audioAddr: ").Append(AudioAddr).Append("\n");
            sb.Append("  sessionId: ").Append(SessionId).Append("\n");
            sb.Append("  outputDataVersion: ").Append(OutputDataVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OutputInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OutputInfo input)
        {
            if (input == null) return false;
            if (this.FaceAddr != input.FaceAddr || (this.FaceAddr != null && !this.FaceAddr.Equals(input.FaceAddr))) return false;
            if (this.BodyAddr != input.BodyAddr || (this.BodyAddr != null && !this.BodyAddr.Equals(input.BodyAddr))) return false;
            if (this.AudioAddr != input.AudioAddr || (this.AudioAddr != null && !this.AudioAddr.Equals(input.AudioAddr))) return false;
            if (this.SessionId != input.SessionId || (this.SessionId != null && !this.SessionId.Equals(input.SessionId))) return false;
            if (this.OutputDataVersion != input.OutputDataVersion || (this.OutputDataVersion != null && !this.OutputDataVersion.Equals(input.OutputDataVersion))) return false;

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
                if (this.FaceAddr != null) hashCode = hashCode * 59 + this.FaceAddr.GetHashCode();
                if (this.BodyAddr != null) hashCode = hashCode * 59 + this.BodyAddr.GetHashCode();
                if (this.AudioAddr != null) hashCode = hashCode * 59 + this.AudioAddr.GetHashCode();
                if (this.SessionId != null) hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.OutputDataVersion != null) hashCode = hashCode * 59 + this.OutputDataVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
