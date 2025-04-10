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
    /// Request Object
    /// </summary>
    public class DeleteAutopilotClusterRequest 
    {
        /// <summary>
        /// 是否删除SFS Turbo（极速文件存储卷）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程，默认选项)
        /// </summary>
        /// <value>是否删除SFS Turbo（极速文件存储卷）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程，默认选项)</value>
        [JsonConverter(typeof(EnumClassConverter<DeleteEfsEnum>))]
        public class DeleteEfsEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly DeleteEfsEnum TRUE = new DeleteEfsEnum("true");

            /// <summary>
            /// Enum BLOCK for value: block
            /// </summary>
            public static readonly DeleteEfsEnum BLOCK = new DeleteEfsEnum("block");

            /// <summary>
            /// Enum TRY for value: try
            /// </summary>
            public static readonly DeleteEfsEnum TRY = new DeleteEfsEnum("try");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly DeleteEfsEnum FALSE = new DeleteEfsEnum("false");

            /// <summary>
            /// Enum SKIP for value: skip
            /// </summary>
            public static readonly DeleteEfsEnum SKIP = new DeleteEfsEnum("skip");

            private static readonly Dictionary<string, DeleteEfsEnum> StaticFields =
            new Dictionary<string, DeleteEfsEnum>()
            {
                { "true", TRUE },
                { "block", BLOCK },
                { "try", TRY },
                { "false", FALSE },
                { "skip", SKIP },
            };

            private string _value;

            public DeleteEfsEnum()
            {

            }

            public DeleteEfsEnum(string value)
            {
                _value = value;
            }

            public static DeleteEfsEnum FromValue(string value)
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

                if (this.Equals(obj as DeleteEfsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeleteEfsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DeleteEfsEnum a, DeleteEfsEnum b)
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

            public static bool operator !=(DeleteEfsEnum a, DeleteEfsEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 是否删除eni ports（原生弹性网卡）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程，默认选项) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程)
        /// </summary>
        /// <value>是否删除eni ports（原生弹性网卡）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程，默认选项) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程)</value>
        [JsonConverter(typeof(EnumClassConverter<DeleteEniEnum>))]
        public class DeleteEniEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly DeleteEniEnum TRUE = new DeleteEniEnum("true");

            /// <summary>
            /// Enum BLOCK for value: block
            /// </summary>
            public static readonly DeleteEniEnum BLOCK = new DeleteEniEnum("block");

            /// <summary>
            /// Enum TRY for value: try
            /// </summary>
            public static readonly DeleteEniEnum TRY = new DeleteEniEnum("try");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly DeleteEniEnum FALSE = new DeleteEniEnum("false");

            /// <summary>
            /// Enum SKIP for value: skip
            /// </summary>
            public static readonly DeleteEniEnum SKIP = new DeleteEniEnum("skip");

            private static readonly Dictionary<string, DeleteEniEnum> StaticFields =
            new Dictionary<string, DeleteEniEnum>()
            {
                { "true", TRUE },
                { "block", BLOCK },
                { "try", TRY },
                { "false", FALSE },
                { "skip", SKIP },
            };

            private string _value;

            public DeleteEniEnum()
            {

            }

            public DeleteEniEnum(string value)
            {
                _value = value;
            }

            public static DeleteEniEnum FromValue(string value)
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

                if (this.Equals(obj as DeleteEniEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeleteEniEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DeleteEniEnum a, DeleteEniEnum b)
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

            public static bool operator !=(DeleteEniEnum a, DeleteEniEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 是否删除elb（弹性负载均衡）等集群Service/Ingress相关资源。 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程，默认选项) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程)
        /// </summary>
        /// <value>是否删除elb（弹性负载均衡）等集群Service/Ingress相关资源。 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程，默认选项) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程)</value>
        [JsonConverter(typeof(EnumClassConverter<DeleteNetEnum>))]
        public class DeleteNetEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly DeleteNetEnum TRUE = new DeleteNetEnum("true");

            /// <summary>
            /// Enum BLOCK for value: block
            /// </summary>
            public static readonly DeleteNetEnum BLOCK = new DeleteNetEnum("block");

            /// <summary>
            /// Enum TRY for value: try
            /// </summary>
            public static readonly DeleteNetEnum TRY = new DeleteNetEnum("try");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly DeleteNetEnum FALSE = new DeleteNetEnum("false");

            /// <summary>
            /// Enum SKIP for value: skip
            /// </summary>
            public static readonly DeleteNetEnum SKIP = new DeleteNetEnum("skip");

            private static readonly Dictionary<string, DeleteNetEnum> StaticFields =
            new Dictionary<string, DeleteNetEnum>()
            {
                { "true", TRUE },
                { "block", BLOCK },
                { "try", TRY },
                { "false", FALSE },
                { "skip", SKIP },
            };

            private string _value;

            public DeleteNetEnum()
            {

            }

            public DeleteNetEnum(string value)
            {
                _value = value;
            }

            public static DeleteNetEnum FromValue(string value)
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

                if (this.Equals(obj as DeleteNetEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeleteNetEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DeleteNetEnum a, DeleteNetEnum b)
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

            public static bool operator !=(DeleteNetEnum a, DeleteNetEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 是否删除obs（对象存储卷）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程，默认选项)
        /// </summary>
        /// <value>是否删除obs（对象存储卷）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程，默认选项)</value>
        [JsonConverter(typeof(EnumClassConverter<DeleteObsEnum>))]
        public class DeleteObsEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly DeleteObsEnum TRUE = new DeleteObsEnum("true");

            /// <summary>
            /// Enum BLOCK for value: block
            /// </summary>
            public static readonly DeleteObsEnum BLOCK = new DeleteObsEnum("block");

            /// <summary>
            /// Enum TRY for value: try
            /// </summary>
            public static readonly DeleteObsEnum TRY = new DeleteObsEnum("try");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly DeleteObsEnum FALSE = new DeleteObsEnum("false");

            /// <summary>
            /// Enum SKIP for value: skip
            /// </summary>
            public static readonly DeleteObsEnum SKIP = new DeleteObsEnum("skip");

            private static readonly Dictionary<string, DeleteObsEnum> StaticFields =
            new Dictionary<string, DeleteObsEnum>()
            {
                { "true", TRUE },
                { "block", BLOCK },
                { "try", TRY },
                { "false", FALSE },
                { "skip", SKIP },
            };

            private string _value;

            public DeleteObsEnum()
            {

            }

            public DeleteObsEnum(string value)
            {
                _value = value;
            }

            public static DeleteObsEnum FromValue(string value)
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

                if (this.Equals(obj as DeleteObsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeleteObsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DeleteObsEnum a, DeleteObsEnum b)
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

            public static bool operator !=(DeleteObsEnum a, DeleteObsEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 是否删除sfs3.0（文件存储卷3.0）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程，默认选项)
        /// </summary>
        /// <value>是否删除sfs3.0（文件存储卷3.0）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程，默认选项)</value>
        [JsonConverter(typeof(EnumClassConverter<DeleteSfs30Enum>))]
        public class DeleteSfs30Enum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly DeleteSfs30Enum TRUE = new DeleteSfs30Enum("true");

            /// <summary>
            /// Enum BLOCK for value: block
            /// </summary>
            public static readonly DeleteSfs30Enum BLOCK = new DeleteSfs30Enum("block");

            /// <summary>
            /// Enum TRY for value: try
            /// </summary>
            public static readonly DeleteSfs30Enum TRY = new DeleteSfs30Enum("try");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly DeleteSfs30Enum FALSE = new DeleteSfs30Enum("false");

            /// <summary>
            /// Enum SKIP for value: skip
            /// </summary>
            public static readonly DeleteSfs30Enum SKIP = new DeleteSfs30Enum("skip");

            private static readonly Dictionary<string, DeleteSfs30Enum> StaticFields =
            new Dictionary<string, DeleteSfs30Enum>()
            {
                { "true", TRUE },
                { "block", BLOCK },
                { "try", TRY },
                { "false", FALSE },
                { "skip", SKIP },
            };

            private string _value;

            public DeleteSfs30Enum()
            {

            }

            public DeleteSfs30Enum(string value)
            {
                _value = value;
            }

            public static DeleteSfs30Enum FromValue(string value)
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

                if (this.Equals(obj as DeleteSfs30Enum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeleteSfs30Enum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DeleteSfs30Enum a, DeleteSfs30Enum b)
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

            public static bool operator !=(DeleteSfs30Enum a, DeleteSfs30Enum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 是否删除LTS资源（日志组/日志流）。 枚举取值： - Delete_Log_Group：删除日志组，失败则忽略，并继续执行后续流程。 - Delete_Master_Log_Stream：删除Master接入日志流，失败则忽略，并继续执行后续流程，默认选项。 - Retain：跳过删除流程。
        /// </summary>
        /// <value>是否删除LTS资源（日志组/日志流）。 枚举取值： - Delete_Log_Group：删除日志组，失败则忽略，并继续执行后续流程。 - Delete_Master_Log_Stream：删除Master接入日志流，失败则忽略，并继续执行后续流程，默认选项。 - Retain：跳过删除流程。</value>
        [JsonConverter(typeof(EnumClassConverter<LtsReclaimPolicyEnum>))]
        public class LtsReclaimPolicyEnum
        {
            /// <summary>
            /// Enum DELETE_LOG_GROUP for value: Delete_Log_Group
            /// </summary>
            public static readonly LtsReclaimPolicyEnum DELETE_LOG_GROUP = new LtsReclaimPolicyEnum("Delete_Log_Group");

            /// <summary>
            /// Enum DELETE_MASTER_LOG_STREAM for value: Delete_Master_Log_Stream
            /// </summary>
            public static readonly LtsReclaimPolicyEnum DELETE_MASTER_LOG_STREAM = new LtsReclaimPolicyEnum("Delete_Master_Log_Stream");

            /// <summary>
            /// Enum RETAIN for value: Retain
            /// </summary>
            public static readonly LtsReclaimPolicyEnum RETAIN = new LtsReclaimPolicyEnum("Retain");

            private static readonly Dictionary<string, LtsReclaimPolicyEnum> StaticFields =
            new Dictionary<string, LtsReclaimPolicyEnum>()
            {
                { "Delete_Log_Group", DELETE_LOG_GROUP },
                { "Delete_Master_Log_Stream", DELETE_MASTER_LOG_STREAM },
                { "Retain", RETAIN },
            };

            private string _value;

            public LtsReclaimPolicyEnum()
            {

            }

            public LtsReclaimPolicyEnum(string value)
            {
                _value = value;
            }

            public static LtsReclaimPolicyEnum FromValue(string value)
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

                if (this.Equals(obj as LtsReclaimPolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LtsReclaimPolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LtsReclaimPolicyEnum a, LtsReclaimPolicyEnum b)
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

            public static bool operator !=(LtsReclaimPolicyEnum a, LtsReclaimPolicyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 集群ID，获取方式请参见[如何获取接口URI中参数](cce_02_0271.xml)。
        /// </summary>
        [SDKProperty("cluster_id", IsPath = true)]
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 是否删除SFS Turbo（极速文件存储卷）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程，默认选项)
        /// </summary>
        [SDKProperty("delete_efs", IsQuery = true)]
        [JsonProperty("delete_efs", NullValueHandling = NullValueHandling.Ignore)]
        public DeleteEfsEnum DeleteEfs { get; set; }
        /// <summary>
        /// 是否删除eni ports（原生弹性网卡）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程，默认选项) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程)
        /// </summary>
        [SDKProperty("delete_eni", IsQuery = true)]
        [JsonProperty("delete_eni", NullValueHandling = NullValueHandling.Ignore)]
        public DeleteEniEnum DeleteEni { get; set; }
        /// <summary>
        /// 是否删除elb（弹性负载均衡）等集群Service/Ingress相关资源。 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程，默认选项) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程)
        /// </summary>
        [SDKProperty("delete_net", IsQuery = true)]
        [JsonProperty("delete_net", NullValueHandling = NullValueHandling.Ignore)]
        public DeleteNetEnum DeleteNet { get; set; }
        /// <summary>
        /// 是否删除obs（对象存储卷）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程，默认选项)
        /// </summary>
        [SDKProperty("delete_obs", IsQuery = true)]
        [JsonProperty("delete_obs", NullValueHandling = NullValueHandling.Ignore)]
        public DeleteObsEnum DeleteObs { get; set; }
        /// <summary>
        /// 是否删除sfs3.0（文件存储卷3.0）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程，默认选项)
        /// </summary>
        [SDKProperty("delete_sfs30", IsQuery = true)]
        [JsonProperty("delete_sfs30", NullValueHandling = NullValueHandling.Ignore)]
        public DeleteSfs30Enum DeleteSfs30 { get; set; }
        /// <summary>
        /// 是否删除LTS资源（日志组/日志流）。 枚举取值： - Delete_Log_Group：删除日志组，失败则忽略，并继续执行后续流程。 - Delete_Master_Log_Stream：删除Master接入日志流，失败则忽略，并继续执行后续流程，默认选项。 - Retain：跳过删除流程。
        /// </summary>
        [SDKProperty("lts_reclaim_policy", IsQuery = true)]
        [JsonProperty("lts_reclaim_policy", NullValueHandling = NullValueHandling.Ignore)]
        public LtsReclaimPolicyEnum LtsReclaimPolicy { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteAutopilotClusterRequest {\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  deleteEfs: ").Append(DeleteEfs).Append("\n");
            sb.Append("  deleteEni: ").Append(DeleteEni).Append("\n");
            sb.Append("  deleteNet: ").Append(DeleteNet).Append("\n");
            sb.Append("  deleteObs: ").Append(DeleteObs).Append("\n");
            sb.Append("  deleteSfs30: ").Append(DeleteSfs30).Append("\n");
            sb.Append("  ltsReclaimPolicy: ").Append(LtsReclaimPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteAutopilotClusterRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteAutopilotClusterRequest input)
        {
            if (input == null) return false;
            if (this.ClusterId != input.ClusterId || (this.ClusterId != null && !this.ClusterId.Equals(input.ClusterId))) return false;
            if (this.DeleteEfs != input.DeleteEfs) return false;
            if (this.DeleteEni != input.DeleteEni) return false;
            if (this.DeleteNet != input.DeleteNet) return false;
            if (this.DeleteObs != input.DeleteObs) return false;
            if (this.DeleteSfs30 != input.DeleteSfs30) return false;
            if (this.LtsReclaimPolicy != input.LtsReclaimPolicy) return false;

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
                if (this.ClusterId != null) hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                hashCode = hashCode * 59 + this.DeleteEfs.GetHashCode();
                hashCode = hashCode * 59 + this.DeleteEni.GetHashCode();
                hashCode = hashCode * 59 + this.DeleteNet.GetHashCode();
                hashCode = hashCode * 59 + this.DeleteObs.GetHashCode();
                hashCode = hashCode * 59 + this.DeleteSfs30.GetHashCode();
                hashCode = hashCode * 59 + this.LtsReclaimPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
