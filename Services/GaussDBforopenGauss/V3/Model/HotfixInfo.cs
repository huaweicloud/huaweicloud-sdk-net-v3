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
    /// 热补丁信息
    /// </summary>
    public class HotfixInfo 
    {
        /// <summary>
        /// 通用非通用信息,common&#x3D;通用补丁,certain&#x3D;定制补丁
        /// </summary>
        /// <value>通用非通用信息,common&#x3D;通用补丁,certain&#x3D;定制补丁</value>
        [JsonConverter(typeof(EnumClassConverter<CommonPatchEnum>))]
        public class CommonPatchEnum
        {
            /// <summary>
            /// Enum COMMON for value: common
            /// </summary>
            public static readonly CommonPatchEnum COMMON = new CommonPatchEnum("common");

            /// <summary>
            /// Enum CERTAIN for value: certain
            /// </summary>
            public static readonly CommonPatchEnum CERTAIN = new CommonPatchEnum("certain");

            private static readonly Dictionary<string, CommonPatchEnum> StaticFields =
            new Dictionary<string, CommonPatchEnum>()
            {
                { "common", COMMON },
                { "certain", CERTAIN },
            };

            private string _value;

            public CommonPatchEnum()
            {

            }

            public CommonPatchEnum(string value)
            {
                _value = value;
            }

            public static CommonPatchEnum FromValue(string value)
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

                if (this.Equals(obj as CommonPatchEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CommonPatchEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CommonPatchEnum a, CommonPatchEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(CommonPatchEnum a, CommonPatchEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 热补丁版本
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 通用非通用信息,common&#x3D;通用补丁,certain&#x3D;定制补丁
        /// </summary>
        [JsonProperty("common_patch", NullValueHandling = NullValueHandling.Ignore)]
        public CommonPatchEnum CommonPatch { get; set; }
        /// <summary>
        /// 是否和备份相关
        /// </summary>
        [JsonProperty("backup_sensitive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BackupSensitive { get; set; }

        /// <summary>
        /// 补丁的描述信息
        /// </summary>
        [JsonProperty("descripition", NullValueHandling = NullValueHandling.Ignore)]
        public string Descripition { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HotfixInfo {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  commonPatch: ").Append(CommonPatch).Append("\n");
            sb.Append("  backupSensitive: ").Append(BackupSensitive).Append("\n");
            sb.Append("  descripition: ").Append(Descripition).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HotfixInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HotfixInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.CommonPatch == input.CommonPatch ||
                    (this.CommonPatch != null &&
                    this.CommonPatch.Equals(input.CommonPatch))
                ) && 
                (
                    this.BackupSensitive == input.BackupSensitive ||
                    (this.BackupSensitive != null &&
                    this.BackupSensitive.Equals(input.BackupSensitive))
                ) && 
                (
                    this.Descripition == input.Descripition ||
                    (this.Descripition != null &&
                    this.Descripition.Equals(input.Descripition))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.CommonPatch != null)
                    hashCode = hashCode * 59 + this.CommonPatch.GetHashCode();
                if (this.BackupSensitive != null)
                    hashCode = hashCode * 59 + this.BackupSensitive.GetHashCode();
                if (this.Descripition != null)
                    hashCode = hashCode * 59 + this.Descripition.GetHashCode();
                return hashCode;
            }
        }
    }
}
