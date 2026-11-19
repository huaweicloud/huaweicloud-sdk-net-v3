using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SqlPatchInfosResult 
    {
        /// <summary>
        /// **参数解释**: Patch的状态。d表示SQL ID模式，h表示SQL Hash模式。 **取值范围**: - d：SQL ID模式 - h：SQL Hash模式
        /// </summary>
        /// <value>**参数解释**: Patch的状态。d表示SQL ID模式，h表示SQL Hash模式。 **取值范围**: - d：SQL ID模式 - h：SQL Hash模式</value>
        [JsonConverter(typeof(EnumClassConverter<PatchStatusEnum>))]
        public class PatchStatusEnum
        {
            /// <summary>
            /// Enum D for value: d
            /// </summary>
            public static readonly PatchStatusEnum D = new PatchStatusEnum("d");

            /// <summary>
            /// Enum H for value: h
            /// </summary>
            public static readonly PatchStatusEnum H = new PatchStatusEnum("h");

            private static readonly Dictionary<string, PatchStatusEnum> StaticFields =
            new Dictionary<string, PatchStatusEnum>()
            {
                { "d", D },
                { "h", H },
            };

            private string _value;

            public PatchStatusEnum()
            {

            }

            public PatchStatusEnum(string value)
            {
                _value = value;
            }

            public static PatchStatusEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as PatchStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PatchStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PatchStatusEnum a, PatchStatusEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(PatchStatusEnum a, PatchStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**: Patch名称。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("patch_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PatchName { get; set; }

        /// <summary>
        /// **参数解释**: unique_sql_id，标识SQL文本的ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("sql_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlId { get; set; }

        /// <summary>
        /// **参数解释**: Patch是否生效。 **取值范围**: - true：生效 - false：不生效
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// **参数解释**: Patch的状态。d表示SQL ID模式，h表示SQL Hash模式。 **取值范围**: - d：SQL ID模式 - h：SQL Hash模式
        /// </summary>
        [JsonProperty("patch_status", NullValueHandling = NullValueHandling.Ignore)]
        public PatchStatusEnum PatchStatus { get; set; }
        /// <summary>
        /// **参数解释**: 是否为Abort Patch。 **取值范围**: - true：是 - false：否
        /// </summary>
        [JsonProperty("abort_patch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AbortPatch { get; set; }

        /// <summary>
        /// **参数解释**: Patch内容（Hint文本）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("hint", NullValueHandling = NullValueHandling.Ignore)]
        public string Hint { get; set; }

        /// <summary>
        /// **参数解释**: SQL文本。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("sql_text", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlText { get; set; }

        /// <summary>
        /// **参数解释**: SQL Patch所属的节点。主备版为主DN，分布式版为CN。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SqlPatchInfosResult {\n");
            sb.Append("  patchName: ").Append(PatchName).Append("\n");
            sb.Append("  sqlId: ").Append(SqlId).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  patchStatus: ").Append(PatchStatus).Append("\n");
            sb.Append("  abortPatch: ").Append(AbortPatch).Append("\n");
            sb.Append("  hint: ").Append(Hint).Append("\n");
            sb.Append("  sqlText: ").Append(SqlText).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SqlPatchInfosResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SqlPatchInfosResult input)
        {
            if (input == null) return false;
            if (this.PatchName != input.PatchName || (this.PatchName != null && !this.PatchName.Equals(input.PatchName))) return false;
            if (this.SqlId != input.SqlId || (this.SqlId != null && !this.SqlId.Equals(input.SqlId))) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;
            if (this.PatchStatus != input.PatchStatus) return false;
            if (this.AbortPatch != input.AbortPatch || (this.AbortPatch != null && !this.AbortPatch.Equals(input.AbortPatch))) return false;
            if (this.Hint != input.Hint || (this.Hint != null && !this.Hint.Equals(input.Hint))) return false;
            if (this.SqlText != input.SqlText || (this.SqlText != null && !this.SqlText.Equals(input.SqlText))) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;

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
                if (this.PatchName != null) hashCode = hashCode * 59 + this.PatchName.GetHashCode();
                if (this.SqlId != null) hashCode = hashCode * 59 + this.SqlId.GetHashCode();
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                hashCode = hashCode * 59 + this.PatchStatus.GetHashCode();
                if (this.AbortPatch != null) hashCode = hashCode * 59 + this.AbortPatch.GetHashCode();
                if (this.Hint != null) hashCode = hashCode * 59 + this.Hint.GetHashCode();
                if (this.SqlText != null) hashCode = hashCode * 59 + this.SqlText.GetHashCode();
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                return hashCode;
            }
        }
    }
}
