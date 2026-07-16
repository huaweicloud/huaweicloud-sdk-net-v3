using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NotebookResp 
    {
        /// <summary>
        /// **参数解释**：实例状态。 **取值范围**：枚举类型，取值如下： - INIT：初始化 - CREATING：创建中 - STARTING：启动中 - STOPPING：停止中 - DELETING：删除中 - RUNNING：运行中 - STOPPED：已停止 - SNAPSHOTTING：快照中(保存镜像时的状态) - CREATE_FAILED：创建失败 - START_FAILED：启动失败 - DELETE_FAILED：删除失败 - ERROR：错误 - DELETED：已删除 - FROZEN：冻结
        /// </summary>
        /// <value>**参数解释**：实例状态。 **取值范围**：枚举类型，取值如下： - INIT：初始化 - CREATING：创建中 - STARTING：启动中 - STOPPING：停止中 - DELETING：删除中 - RUNNING：运行中 - STOPPED：已停止 - SNAPSHOTTING：快照中(保存镜像时的状态) - CREATE_FAILED：创建失败 - START_FAILED：启动失败 - DELETE_FAILED：删除失败 - ERROR：错误 - DELETED：已删除 - FROZEN：冻结</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum CREATE_FAILED for value: CREATE_FAILED
            /// </summary>
            public static readonly StatusEnum CREATE_FAILED = new StatusEnum("CREATE_FAILED");

            /// <summary>
            /// Enum CREATING for value: CREATING
            /// </summary>
            public static readonly StatusEnum CREATING = new StatusEnum("CREATING");

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            public static readonly StatusEnum DELETED = new StatusEnum("DELETED");

            /// <summary>
            /// Enum DELETE_FAILED for value: DELETE_FAILED
            /// </summary>
            public static readonly StatusEnum DELETE_FAILED = new StatusEnum("DELETE_FAILED");

            /// <summary>
            /// Enum DELETING for value: DELETING
            /// </summary>
            public static readonly StatusEnum DELETING = new StatusEnum("DELETING");

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            public static readonly StatusEnum ERROR = new StatusEnum("ERROR");

            /// <summary>
            /// Enum FROZEN for value: FROZEN
            /// </summary>
            public static readonly StatusEnum FROZEN = new StatusEnum("FROZEN");

            /// <summary>
            /// Enum INIT for value: INIT
            /// </summary>
            public static readonly StatusEnum INIT = new StatusEnum("INIT");

            /// <summary>
            /// Enum RUNNING for value: RUNNING
            /// </summary>
            public static readonly StatusEnum RUNNING = new StatusEnum("RUNNING");

            /// <summary>
            /// Enum SNAPSHOTTING for value: SNAPSHOTTING
            /// </summary>
            public static readonly StatusEnum SNAPSHOTTING = new StatusEnum("SNAPSHOTTING");

            /// <summary>
            /// Enum STARTING for value: STARTING
            /// </summary>
            public static readonly StatusEnum STARTING = new StatusEnum("STARTING");

            /// <summary>
            /// Enum START_FAILED for value: START_FAILED
            /// </summary>
            public static readonly StatusEnum START_FAILED = new StatusEnum("START_FAILED");

            /// <summary>
            /// Enum STOPPED for value: STOPPED
            /// </summary>
            public static readonly StatusEnum STOPPED = new StatusEnum("STOPPED");

            /// <summary>
            /// Enum STOPPING for value: STOPPING
            /// </summary>
            public static readonly StatusEnum STOPPING = new StatusEnum("STOPPING");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "CREATE_FAILED", CREATE_FAILED },
                { "CREATING", CREATING },
                { "DELETED", DELETED },
                { "DELETE_FAILED", DELETE_FAILED },
                { "DELETING", DELETING },
                { "ERROR", ERROR },
                { "FROZEN", FROZEN },
                { "INIT", INIT },
                { "RUNNING", RUNNING },
                { "SNAPSHOTTING", SNAPSHOTTING },
                { "STARTING", STARTING },
                { "START_FAILED", START_FAILED },
                { "STOPPED", STOPPED },
                { "STOPPING", STOPPING },
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines billingItems
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<BillingItemsEnum>))]
        public class BillingItemsEnum
        {
            /// <summary>
            /// Enum STORAGE for value: STORAGE
            /// </summary>
            public static readonly BillingItemsEnum STORAGE = new BillingItemsEnum("STORAGE");

            /// <summary>
            /// Enum COMPUTE for value: COMPUTE
            /// </summary>
            public static readonly BillingItemsEnum COMPUTE = new BillingItemsEnum("COMPUTE");

            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            public static readonly BillingItemsEnum ALL = new BillingItemsEnum("ALL");

            private static readonly Dictionary<string, BillingItemsEnum> StaticFields =
            new Dictionary<string, BillingItemsEnum>()
            {
                { "STORAGE", STORAGE },
                { "COMPUTE", COMPUTE },
                { "ALL", ALL },
            };

            private string _value;

            public BillingItemsEnum()
            {

            }

            public BillingItemsEnum(string value)
            {
                _value = value;
            }

            public static BillingItemsEnum FromValue(string value)
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

                if (this.Equals(obj as BillingItemsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BillingItemsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BillingItemsEnum a, BillingItemsEnum b)
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

            public static bool operator !=(BillingItemsEnum a, BillingItemsEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// **参数解释**：实例初始化进度。
        /// </summary>
        [JsonProperty("action_progress", NullValueHandling = NullValueHandling.Ignore)]
        public List<JobProgress> ActionProgress { get; set; }

        /// <summary>
        /// **参数解释**：实例描述。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**：本地IDE（如PyCharm、VS Code）或SSH客户端，通过SSH远程接入Notebook实例时需要的相关配置。
        /// </summary>
        [JsonProperty("endpoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<EndpointsRes> Endpoints { get; set; }

        /// <summary>
        /// **参数解释**：实例失败原因。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("fail_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string FailReason { get; set; }

        /// <summary>
        /// **参数解释**：实例规格， 1.当用户选择系统规格时，返回值为系统规格码； 2.当用户创建实例时选择了自定义规格，则此字段会固定返回\&quot;custom.flavor.spec.code\&quot;。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string Flavor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_spec", NullValueHandling = NullValueHandling.Ignore)]
        public NotebookCustomSpecRep CustomSpec { get; set; }

        /// <summary>
        /// **参数解释**：实例ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public Image Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lease", NullValueHandling = NullValueHandling.Ignore)]
        public Lease Lease { get; set; }

        /// <summary>
        /// **参数解释**：实例名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pool", NullValueHandling = NullValueHandling.Ignore)]
        public Pool Pool { get; set; }

        /// <summary>
        /// **参数解释**：实例状态。 **取值范围**：枚举类型，取值如下： - INIT：初始化 - CREATING：创建中 - STARTING：启动中 - STOPPING：停止中 - DELETING：删除中 - RUNNING：运行中 - STOPPED：已停止 - SNAPSHOTTING：快照中(保存镜像时的状态) - CREATE_FAILED：创建失败 - START_FAILED：启动失败 - DELETE_FAILED：删除失败 - ERROR：错误 - DELETED：已删除 - FROZEN：冻结
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// **参数解释**：Notebook鉴权使用的token信息。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// **参数解释**：实例访问的URL。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public VolumeRes Volume { get; set; }

        /// <summary>
        /// **参数解释**：工作空间ID。未创建工作空间时默认值为“0”，存在创建并使用的工作空间，以实际取值为准。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// **参数解释**：实例类别。 **取值范围**：枚举类型，取值如下： - DEFAULT：CodeLab免费规格实例，每个用户最多只能创建一个。 - NOTEBOOK：计费规格实例。
        /// </summary>
        [JsonProperty("feature", NullValueHandling = NullValueHandling.Ignore)]
        public string Feature { get; set; }

        /// <summary>
        /// **参数解释**：计费资源类型。枚举类型，取值如下： - STORAGE：存储资源计费。 - COMPUTE：计算资源计费。 - ALL：所有计费类型。
        /// </summary>
        [JsonProperty("billing_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<BillingItemsEnum> BillingItems { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public UserResponse User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("affinity", NullValueHandling = NullValueHandling.Ignore)]
        public AffinityType Affinity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("run_user", NullValueHandling = NullValueHandling.Ignore)]
        public RunUserInfo RunUser { get; set; }

        /// <summary>
        /// **参数解释**：扩展存储信息
        /// </summary>
        [JsonProperty("data_volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<VolumeResponse> DataVolumes { get; set; }

        /// <summary>
        /// **参数解释**：实例所在节点ip。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user_vpc", NullValueHandling = NullValueHandling.Ignore)]
        public UserVpcResponse UserVpc { get; set; }

        /// <summary>
        /// **参数解释**：用户ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// **参数解释**：是否需要默认创建用户secret，默认为true。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("is_need_credentials", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNeedCredentials { get; set; }

        /// <summary>
        /// **参数解释**：jupyter version版本号。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("jupyter_version", NullValueHandling = NullValueHandling.Ignore)]
        public string JupyterVersion { get; set; }

        /// <summary>
        /// **参数解释**：实例标签。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TmsTagResponse> Tags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotebookResp {\n");
            sb.Append("  actionProgress: ").Append(ActionProgress).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  endpoints: ").Append(Endpoints).Append("\n");
            sb.Append("  failReason: ").Append(FailReason).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  customSpec: ").Append(CustomSpec).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  lease: ").Append(Lease).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  pool: ").Append(Pool).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  token: ").Append(Token).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  volume: ").Append(Volume).Append("\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  feature: ").Append(Feature).Append("\n");
            sb.Append("  billingItems: ").Append(BillingItems).Append("\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("  affinity: ").Append(Affinity).Append("\n");
            sb.Append("  runUser: ").Append(RunUser).Append("\n");
            sb.Append("  dataVolumes: ").Append(DataVolumes).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  userVpc: ").Append(UserVpc).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  isNeedCredentials: ").Append(IsNeedCredentials).Append("\n");
            sb.Append("  jupyterVersion: ").Append(JupyterVersion).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NotebookResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NotebookResp input)
        {
            if (input == null) return false;
            if (this.ActionProgress != input.ActionProgress || (this.ActionProgress != null && input.ActionProgress != null && !this.ActionProgress.SequenceEqual(input.ActionProgress))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Endpoints != input.Endpoints || (this.Endpoints != null && input.Endpoints != null && !this.Endpoints.SequenceEqual(input.Endpoints))) return false;
            if (this.FailReason != input.FailReason || (this.FailReason != null && !this.FailReason.Equals(input.FailReason))) return false;
            if (this.Flavor != input.Flavor || (this.Flavor != null && !this.Flavor.Equals(input.Flavor))) return false;
            if (this.CustomSpec != input.CustomSpec || (this.CustomSpec != null && !this.CustomSpec.Equals(input.CustomSpec))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Image != input.Image || (this.Image != null && !this.Image.Equals(input.Image))) return false;
            if (this.Lease != input.Lease || (this.Lease != null && !this.Lease.Equals(input.Lease))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Pool != input.Pool || (this.Pool != null && !this.Pool.Equals(input.Pool))) return false;
            if (this.Status != input.Status) return false;
            if (this.Token != input.Token || (this.Token != null && !this.Token.Equals(input.Token))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.Volume != input.Volume || (this.Volume != null && !this.Volume.Equals(input.Volume))) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.Feature != input.Feature || (this.Feature != null && !this.Feature.Equals(input.Feature))) return false;
            if (this.BillingItems != input.BillingItems || (this.BillingItems != null && input.BillingItems != null && !this.BillingItems.SequenceEqual(input.BillingItems))) return false;
            if (this.User != input.User || (this.User != null && !this.User.Equals(input.User))) return false;
            if (this.Affinity != input.Affinity || (this.Affinity != null && !this.Affinity.Equals(input.Affinity))) return false;
            if (this.RunUser != input.RunUser || (this.RunUser != null && !this.RunUser.Equals(input.RunUser))) return false;
            if (this.DataVolumes != input.DataVolumes || (this.DataVolumes != null && input.DataVolumes != null && !this.DataVolumes.SequenceEqual(input.DataVolumes))) return false;
            if (this.Ip != input.Ip || (this.Ip != null && !this.Ip.Equals(input.Ip))) return false;
            if (this.UserVpc != input.UserVpc || (this.UserVpc != null && !this.UserVpc.Equals(input.UserVpc))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.IsNeedCredentials != input.IsNeedCredentials || (this.IsNeedCredentials != null && !this.IsNeedCredentials.Equals(input.IsNeedCredentials))) return false;
            if (this.JupyterVersion != input.JupyterVersion || (this.JupyterVersion != null && !this.JupyterVersion.Equals(input.JupyterVersion))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;

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
                if (this.ActionProgress != null) hashCode = hashCode * 59 + this.ActionProgress.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Endpoints != null) hashCode = hashCode * 59 + this.Endpoints.GetHashCode();
                if (this.FailReason != null) hashCode = hashCode * 59 + this.FailReason.GetHashCode();
                if (this.Flavor != null) hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.CustomSpec != null) hashCode = hashCode * 59 + this.CustomSpec.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Image != null) hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Lease != null) hashCode = hashCode * 59 + this.Lease.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Pool != null) hashCode = hashCode * 59 + this.Pool.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Token != null) hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Volume != null) hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.Feature != null) hashCode = hashCode * 59 + this.Feature.GetHashCode();
                hashCode = hashCode * 59 + this.BillingItems.GetHashCode();
                if (this.User != null) hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Affinity != null) hashCode = hashCode * 59 + this.Affinity.GetHashCode();
                if (this.RunUser != null) hashCode = hashCode * 59 + this.RunUser.GetHashCode();
                if (this.DataVolumes != null) hashCode = hashCode * 59 + this.DataVolumes.GetHashCode();
                if (this.Ip != null) hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.UserVpc != null) hashCode = hashCode * 59 + this.UserVpc.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.IsNeedCredentials != null) hashCode = hashCode * 59 + this.IsNeedCredentials.GetHashCode();
                if (this.JupyterVersion != null) hashCode = hashCode * 59 + this.JupyterVersion.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
