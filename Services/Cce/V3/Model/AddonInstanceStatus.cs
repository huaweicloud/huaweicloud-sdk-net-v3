using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 插件状态信息
    /// </summary>
    public class AddonInstanceStatus 
    {
        /// <summary>
        /// 插件实例状态
        /// </summary>
        /// <value>插件实例状态</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum RUNNING for value: running
            /// </summary>
            public static readonly StatusEnum RUNNING = new StatusEnum("running");

            /// <summary>
            /// Enum ABNORMAL for value: abnormal
            /// </summary>
            public static readonly StatusEnum ABNORMAL = new StatusEnum("abnormal");

            /// <summary>
            /// Enum INSTALLING for value: installing
            /// </summary>
            public static readonly StatusEnum INSTALLING = new StatusEnum("installing");

            /// <summary>
            /// Enum INSTALLFAILED for value: installFailed
            /// </summary>
            public static readonly StatusEnum INSTALLFAILED = new StatusEnum("installFailed");

            /// <summary>
            /// Enum UPGRADING for value: upgrading
            /// </summary>
            public static readonly StatusEnum UPGRADING = new StatusEnum("upgrading");

            /// <summary>
            /// Enum UPGRADEFAILED for value: upgradeFailed
            /// </summary>
            public static readonly StatusEnum UPGRADEFAILED = new StatusEnum("upgradeFailed");

            /// <summary>
            /// Enum DELETING for value: deleting
            /// </summary>
            public static readonly StatusEnum DELETING = new StatusEnum("deleting");

            /// <summary>
            /// Enum DELETESUCCESS for value: deleteSuccess
            /// </summary>
            public static readonly StatusEnum DELETESUCCESS = new StatusEnum("deleteSuccess");

            /// <summary>
            /// Enum DELETEFAILED for value: deleteFailed
            /// </summary>
            public static readonly StatusEnum DELETEFAILED = new StatusEnum("deleteFailed");

            /// <summary>
            /// Enum AVAILABLE for value: available
            /// </summary>
            public static readonly StatusEnum AVAILABLE = new StatusEnum("available");

            /// <summary>
            /// Enum ROLLBACKING for value: rollbacking
            /// </summary>
            public static readonly StatusEnum ROLLBACKING = new StatusEnum("rollbacking");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "running", RUNNING },
                { "abnormal", ABNORMAL },
                { "installing", INSTALLING },
                { "installFailed", INSTALLFAILED },
                { "upgrading", UPGRADING },
                { "upgradeFailed", UPGRADEFAILED },
                { "deleting", DELETING },
                { "deleteSuccess", DELETESUCCESS },
                { "deleteFailed", DELETEFAILED },
                { "available", AVAILABLE },
                { "rollbacking", ROLLBACKING },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 插件实例状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 插件安装失败原因
        /// </summary>
        [JsonProperty("Reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// 安装错误详情
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 此插件版本，支持升级的集群版本
        /// </summary>
        [JsonProperty("targetVersions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TargetVersions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("currentVersion", NullValueHandling = NullValueHandling.Ignore)]
        public Versions CurrentVersion { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddonInstanceStatus {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  reason: ").Append(Reason).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  targetVersions: ").Append(TargetVersions).Append("\n");
            sb.Append("  currentVersion: ").Append(CurrentVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddonInstanceStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddonInstanceStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.TargetVersions == input.TargetVersions ||
                    this.TargetVersions != null &&
                    input.TargetVersions != null &&
                    this.TargetVersions.SequenceEqual(input.TargetVersions)
                ) && 
                (
                    this.CurrentVersion == input.CurrentVersion ||
                    (this.CurrentVersion != null &&
                    this.CurrentVersion.Equals(input.CurrentVersion))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.TargetVersions != null)
                    hashCode = hashCode * 59 + this.TargetVersions.GetHashCode();
                if (this.CurrentVersion != null)
                    hashCode = hashCode * 59 + this.CurrentVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
