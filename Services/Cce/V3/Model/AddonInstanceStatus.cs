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
        /// 插件实例状态, 取值如下 - running：运行中，表示插件全部实例状态都在运行中，插件正常使用。 - abnormal：不可用，表示插件状态异常，插件不可使用。可点击插件名称查看实例异常事件。 - installing：安装中，表示插件正在安装中。 - installFailed：安装失败，表示插件安装失败，需要卸载后重新安装。 - upgrading：升级中，表示插件正在更新中。 - upgradeFailed：升级失败，表示插件升级失败，可重试升级或卸载后重新安装。 - deleting：删除中，表示插件正在删除中。 - deleteFailed：删除失败，表示插件删除失败，可重试卸载。 - deleteSuccess：删除成功，表示插件删除成功。 - available：部分就绪，表示插件下只有部分实例状态为运行中，插件部分功能可用。 - rollbacking：回滚中，表示插件正在回滚中。 - rollbackFailed：回滚失败，表示插件回滚失败，可重试回滚或卸载后重新安装。 - unknown：未知状态，表示插件模板实例不存在。
        /// </summary>
        /// <value>插件实例状态, 取值如下 - running：运行中，表示插件全部实例状态都在运行中，插件正常使用。 - abnormal：不可用，表示插件状态异常，插件不可使用。可点击插件名称查看实例异常事件。 - installing：安装中，表示插件正在安装中。 - installFailed：安装失败，表示插件安装失败，需要卸载后重新安装。 - upgrading：升级中，表示插件正在更新中。 - upgradeFailed：升级失败，表示插件升级失败，可重试升级或卸载后重新安装。 - deleting：删除中，表示插件正在删除中。 - deleteFailed：删除失败，表示插件删除失败，可重试卸载。 - deleteSuccess：删除成功，表示插件删除成功。 - available：部分就绪，表示插件下只有部分实例状态为运行中，插件部分功能可用。 - rollbacking：回滚中，表示插件正在回滚中。 - rollbackFailed：回滚失败，表示插件回滚失败，可重试回滚或卸载后重新安装。 - unknown：未知状态，表示插件模板实例不存在。</value>
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

            /// <summary>
            /// Enum ROLLBACKFAILED for value: rollbackFailed
            /// </summary>
            public static readonly StatusEnum ROLLBACKFAILED = new StatusEnum("rollbackFailed");

            /// <summary>
            /// Enum UNKNOWN for value: unknown
            /// </summary>
            public static readonly StatusEnum UNKNOWN = new StatusEnum("unknown");

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
                { "rollbackFailed", ROLLBACKFAILED },
                { "unknown", UNKNOWN },
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
        /// 插件实例状态, 取值如下 - running：运行中，表示插件全部实例状态都在运行中，插件正常使用。 - abnormal：不可用，表示插件状态异常，插件不可使用。可点击插件名称查看实例异常事件。 - installing：安装中，表示插件正在安装中。 - installFailed：安装失败，表示插件安装失败，需要卸载后重新安装。 - upgrading：升级中，表示插件正在更新中。 - upgradeFailed：升级失败，表示插件升级失败，可重试升级或卸载后重新安装。 - deleting：删除中，表示插件正在删除中。 - deleteFailed：删除失败，表示插件删除失败，可重试卸载。 - deleteSuccess：删除成功，表示插件删除成功。 - available：部分就绪，表示插件下只有部分实例状态为运行中，插件部分功能可用。 - rollbacking：回滚中，表示插件正在回滚中。 - rollbackFailed：回滚失败，表示插件回滚失败，可重试回滚或卸载后重新安装。 - unknown：未知状态，表示插件模板实例不存在。
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
        /// 是否支持回滚到插件升级前的插件版本
        /// </summary>
        [JsonProperty("isRollbackable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRollbackable { get; set; }

        /// <summary>
        /// 插件升级或回滚前的版本
        /// </summary>
        [JsonProperty("previousVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousVersion { get; set; }



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
            sb.Append("  isRollbackable: ").Append(IsRollbackable).Append("\n");
            sb.Append("  previousVersion: ").Append(PreviousVersion).Append("\n");
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
                ) && 
                (
                    this.IsRollbackable == input.IsRollbackable ||
                    (this.IsRollbackable != null &&
                    this.IsRollbackable.Equals(input.IsRollbackable))
                ) && 
                (
                    this.PreviousVersion == input.PreviousVersion ||
                    (this.PreviousVersion != null &&
                    this.PreviousVersion.Equals(input.PreviousVersion))
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
                if (this.IsRollbackable != null)
                    hashCode = hashCode * 59 + this.IsRollbackable.GetHashCode();
                if (this.PreviousVersion != null)
                    hashCode = hashCode * 59 + this.PreviousVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
