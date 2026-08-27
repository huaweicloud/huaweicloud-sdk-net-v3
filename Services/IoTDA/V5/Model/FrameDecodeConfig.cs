using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 泛协议码流的拆包组包配置
    /// </summary>
    public class FrameDecodeConfig 
    {

        /// <summary>
        /// **参数说明**：拆包组包规则。 **取值范围**： - DELIMITER：通过特定分隔符（如逗号、换行符等）来拆分或组合数据包。 - FIXED_LENGTH：按照固定的字节长度，对每一帧数据进行拆分或组合。 - FIELD_LENGTH：每一帧的长度可变，通过数据包中携带的长度字段信息进行拆分或组合。
        /// </summary>
        [JsonProperty("frame_decode_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FrameDecodeType { get; set; }

        /// <summary>
        /// **参数说明**：单个帧的最大长度。拆包规则为DELIMITER|FIELD_LENGTH时，该参数必选。
        /// </summary>
        [JsonProperty("max_frame_length", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxFrameLength { get; set; }

        /// <summary>
        /// **参数说明**：分隔符，hex string格式。拆包规则为DELIMITER，该参数必选。
        /// </summary>
        [JsonProperty("delimiter", NullValueHandling = NullValueHandling.Ignore)]
        public string Delimiter { get; set; }

        /// <summary>
        /// **参数说明**：单个帧的固定长度。拆包规则为FIXED_LENGTH，该参数必选。
        /// </summary>
        [JsonProperty("fixed_frame_length", NullValueHandling = NullValueHandling.Ignore)]
        public int? FixedFrameLength { get; set; }

        /// <summary>
        /// **参数说明**：指定长度字段在数据包中的起始位置（偏移量）。拆包规则为FIELD_LENGTH ，该参数必选。
        /// </summary>
        [JsonProperty("field_offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? FieldOffset { get; set; }

        /// <summary>
        /// **参数说明**：指定长度字段占用的字节数。拆包规则为FIELD_LENGTH，该参数必选。
        /// </summary>
        [JsonProperty("field_length", NullValueHandling = NullValueHandling.Ignore)]
        public int? FieldLength { get; set; }

        /// <summary>
        /// **参数说明**：起始字符，hex string格式。拆包规则为FIXED_LENGTH，该参数可选。
        /// </summary>
        [JsonProperty("initial_bytes", NullValueHandling = NullValueHandling.Ignore)]
        public string InitialBytes { get; set; }

        /// <summary>
        /// **参数说明**：调整长度字段的值。拆包规则为FIELD_LENGTH，该参数可选。
        /// </summary>
        [JsonProperty("adjustment_length", NullValueHandling = NullValueHandling.Ignore)]
        public int? AdjustmentLength { get; set; }

        /// <summary>
        /// **参数说明**：指定解码后从数据包中去掉的字节数。通常用于去掉长度字段，只保留数据内容。拆包规则为FIELD_LENGTH，该参数可选。
        /// </summary>
        [JsonProperty("initial_bytes_to_strip", NullValueHandling = NullValueHandling.Ignore)]
        public int? InitialBytesToStrip { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FrameDecodeConfig {\n");
            sb.Append("  frameDecodeType: ").Append(FrameDecodeType).Append("\n");
            sb.Append("  maxFrameLength: ").Append(MaxFrameLength).Append("\n");
            sb.Append("  delimiter: ").Append(Delimiter).Append("\n");
            sb.Append("  fixedFrameLength: ").Append(FixedFrameLength).Append("\n");
            sb.Append("  fieldOffset: ").Append(FieldOffset).Append("\n");
            sb.Append("  fieldLength: ").Append(FieldLength).Append("\n");
            sb.Append("  initialBytes: ").Append(InitialBytes).Append("\n");
            sb.Append("  adjustmentLength: ").Append(AdjustmentLength).Append("\n");
            sb.Append("  initialBytesToStrip: ").Append(InitialBytesToStrip).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FrameDecodeConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FrameDecodeConfig input)
        {
            if (input == null) return false;
            if (this.FrameDecodeType != input.FrameDecodeType || (this.FrameDecodeType != null && !this.FrameDecodeType.Equals(input.FrameDecodeType))) return false;
            if (this.MaxFrameLength != input.MaxFrameLength || (this.MaxFrameLength != null && !this.MaxFrameLength.Equals(input.MaxFrameLength))) return false;
            if (this.Delimiter != input.Delimiter || (this.Delimiter != null && !this.Delimiter.Equals(input.Delimiter))) return false;
            if (this.FixedFrameLength != input.FixedFrameLength || (this.FixedFrameLength != null && !this.FixedFrameLength.Equals(input.FixedFrameLength))) return false;
            if (this.FieldOffset != input.FieldOffset || (this.FieldOffset != null && !this.FieldOffset.Equals(input.FieldOffset))) return false;
            if (this.FieldLength != input.FieldLength || (this.FieldLength != null && !this.FieldLength.Equals(input.FieldLength))) return false;
            if (this.InitialBytes != input.InitialBytes || (this.InitialBytes != null && !this.InitialBytes.Equals(input.InitialBytes))) return false;
            if (this.AdjustmentLength != input.AdjustmentLength || (this.AdjustmentLength != null && !this.AdjustmentLength.Equals(input.AdjustmentLength))) return false;
            if (this.InitialBytesToStrip != input.InitialBytesToStrip || (this.InitialBytesToStrip != null && !this.InitialBytesToStrip.Equals(input.InitialBytesToStrip))) return false;

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
                if (this.FrameDecodeType != null) hashCode = hashCode * 59 + this.FrameDecodeType.GetHashCode();
                if (this.MaxFrameLength != null) hashCode = hashCode * 59 + this.MaxFrameLength.GetHashCode();
                if (this.Delimiter != null) hashCode = hashCode * 59 + this.Delimiter.GetHashCode();
                if (this.FixedFrameLength != null) hashCode = hashCode * 59 + this.FixedFrameLength.GetHashCode();
                if (this.FieldOffset != null) hashCode = hashCode * 59 + this.FieldOffset.GetHashCode();
                if (this.FieldLength != null) hashCode = hashCode * 59 + this.FieldLength.GetHashCode();
                if (this.InitialBytes != null) hashCode = hashCode * 59 + this.InitialBytes.GetHashCode();
                if (this.AdjustmentLength != null) hashCode = hashCode * 59 + this.AdjustmentLength.GetHashCode();
                if (this.InitialBytesToStrip != null) hashCode = hashCode * 59 + this.InitialBytesToStrip.GetHashCode();
                return hashCode;
            }
        }
    }
}
