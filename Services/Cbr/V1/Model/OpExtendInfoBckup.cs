using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class OpExtendInfoBckup 
    {
        /// <summary>
        /// 应用一致性备份状态；0:非应用一致性，1：应用一致性备份
        /// </summary>
        /// <value>应用一致性备份状态；0:非应用一致性，1：应用一致性备份</value>
        [JsonConverter(typeof(EnumClassConverter<AppConsistencyStatusEnum>))]
        public class AppConsistencyStatusEnum
        {
            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            public static readonly AppConsistencyStatusEnum _0 = new AppConsistencyStatusEnum("0");

            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            public static readonly AppConsistencyStatusEnum _1 = new AppConsistencyStatusEnum("1");

            private static readonly Dictionary<string, AppConsistencyStatusEnum> StaticFields =
            new Dictionary<string, AppConsistencyStatusEnum>()
            {
                { "0", _0 },
                { "1", _1 },
            };

            private string Value;

            public AppConsistencyStatusEnum(string value)
            {
                Value = value;
            }

            public static AppConsistencyStatusEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as AppConsistencyStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AppConsistencyStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(AppConsistencyStatusEnum a, AppConsistencyStatusEnum b)
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

            public static bool operator !=(AppConsistencyStatusEnum a, AppConsistencyStatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 是否增备
        /// </summary>
        /// <value>是否增备</value>
        [JsonConverter(typeof(EnumClassConverter<IncrementalEnum>))]
        public class IncrementalEnum
        {
            /// <summary>
            /// Enum _TRUE_ for value: \"true\"
            /// </summary>
            public static readonly IncrementalEnum _TRUE_ = new IncrementalEnum("\"true\"");

            /// <summary>
            /// Enum _FALSE_ for value: \"false\"
            /// </summary>
            public static readonly IncrementalEnum _FALSE_ = new IncrementalEnum("\"false\"");

            private static readonly Dictionary<string, IncrementalEnum> StaticFields =
            new Dictionary<string, IncrementalEnum>()
            {
                { "\"true\"", _TRUE_ },
                { "\"false\"", _FALSE_ },
            };

            private string Value;

            public IncrementalEnum(string value)
            {
                Value = value;
            }

            public static IncrementalEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as IncrementalEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IncrementalEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(IncrementalEnum a, IncrementalEnum b)
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

            public static bool operator !=(IncrementalEnum a, IncrementalEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 应用一致性备份失败错误码。请参见[错误码](ErrorCode.xml)。
        /// </summary>
        [JsonProperty("app_consistency_error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AppConsistencyErrorCode { get; set; }

        /// <summary>
        /// 应用一致性备份错误信息
        /// </summary>
        [JsonProperty("app_consistency_error_message", NullValueHandling = NullValueHandling.Ignore)]
        public string AppConsistencyErrorMessage { get; set; }

        /// <summary>
        /// 应用一致性备份状态；0:非应用一致性，1：应用一致性备份
        /// </summary>
        [JsonProperty("app_consistency_status", NullValueHandling = NullValueHandling.Ignore)]
        public AppConsistencyStatusEnum AppConsistencyStatus { get; set; }
        /// <summary>
        /// 备份副本ID
        /// </summary>
        [JsonProperty("backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupId { get; set; }

        /// <summary>
        /// 备份名称
        /// </summary>
        [JsonProperty("backup_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupName { get; set; }

        /// <summary>
        /// 是否增备
        /// </summary>
        [JsonProperty("incremental", NullValueHandling = NullValueHandling.Ignore)]
        public IncrementalEnum Incremental { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpExtendInfoBckup {\n");
            sb.Append("  appConsistencyErrorCode: ").Append(AppConsistencyErrorCode).Append("\n");
            sb.Append("  appConsistencyErrorMessage: ").Append(AppConsistencyErrorMessage).Append("\n");
            sb.Append("  appConsistencyStatus: ").Append(AppConsistencyStatus).Append("\n");
            sb.Append("  backupId: ").Append(BackupId).Append("\n");
            sb.Append("  backupName: ").Append(BackupName).Append("\n");
            sb.Append("  incremental: ").Append(Incremental).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OpExtendInfoBckup);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OpExtendInfoBckup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppConsistencyErrorCode == input.AppConsistencyErrorCode ||
                    (this.AppConsistencyErrorCode != null &&
                    this.AppConsistencyErrorCode.Equals(input.AppConsistencyErrorCode))
                ) && 
                (
                    this.AppConsistencyErrorMessage == input.AppConsistencyErrorMessage ||
                    (this.AppConsistencyErrorMessage != null &&
                    this.AppConsistencyErrorMessage.Equals(input.AppConsistencyErrorMessage))
                ) && 
                (
                    this.AppConsistencyStatus == input.AppConsistencyStatus ||
                    (this.AppConsistencyStatus != null &&
                    this.AppConsistencyStatus.Equals(input.AppConsistencyStatus))
                ) && 
                (
                    this.BackupId == input.BackupId ||
                    (this.BackupId != null &&
                    this.BackupId.Equals(input.BackupId))
                ) && 
                (
                    this.BackupName == input.BackupName ||
                    (this.BackupName != null &&
                    this.BackupName.Equals(input.BackupName))
                ) && 
                (
                    this.Incremental == input.Incremental ||
                    (this.Incremental != null &&
                    this.Incremental.Equals(input.Incremental))
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
                if (this.AppConsistencyErrorCode != null)
                    hashCode = hashCode * 59 + this.AppConsistencyErrorCode.GetHashCode();
                if (this.AppConsistencyErrorMessage != null)
                    hashCode = hashCode * 59 + this.AppConsistencyErrorMessage.GetHashCode();
                if (this.AppConsistencyStatus != null)
                    hashCode = hashCode * 59 + this.AppConsistencyStatus.GetHashCode();
                if (this.BackupId != null)
                    hashCode = hashCode * 59 + this.BackupId.GetHashCode();
                if (this.BackupName != null)
                    hashCode = hashCode * 59 + this.BackupName.GetHashCode();
                if (this.Incremental != null)
                    hashCode = hashCode * 59 + this.Incremental.GetHashCode();
                return hashCode;
            }
        }
    }
}
