using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 池桌面详情。
    /// </summary>
    public class PoolDesktopsDetailInfo 
    {
        /// <summary>
        /// 上网方式。 - NAT：表示NAT上网方式。 - EIP：表示EIP上网方式。 - BOTH：表示两种上网方式都支持。
        /// </summary>
        /// <value>上网方式。 - NAT：表示NAT上网方式。 - EIP：表示EIP上网方式。 - BOTH：表示两种上网方式都支持。</value>
        [JsonConverter(typeof(EnumClassConverter<InternetModeEnum>))]
        public class InternetModeEnum
        {
            /// <summary>
            /// Enum NAT for value: NAT
            /// </summary>
            public static readonly InternetModeEnum NAT = new InternetModeEnum("NAT");

            /// <summary>
            /// Enum EIP for value: EIP
            /// </summary>
            public static readonly InternetModeEnum EIP = new InternetModeEnum("EIP");

            /// <summary>
            /// Enum BOTH for value: BOTH
            /// </summary>
            public static readonly InternetModeEnum BOTH = new InternetModeEnum("BOTH");

            private static readonly Dictionary<string, InternetModeEnum> StaticFields =
            new Dictionary<string, InternetModeEnum>()
            {
                { "NAT", NAT },
                { "EIP", EIP },
                { "BOTH", BOTH },
            };

            private string _value;

            public InternetModeEnum()
            {

            }

            public InternetModeEnum(string value)
            {
                _value = value;
            }

            public static InternetModeEnum FromValue(string value)
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

                if (this.Equals(obj as InternetModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InternetModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InternetModeEnum a, InternetModeEnum b)
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

            public static bool operator !=(InternetModeEnum a, InternetModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 分配状态。 - ATTACHED：已分配。 - UNATTACH：未分配 表示未关联。 - DEATTACHED：已解分配。 - ATTACHING：分配中。 - DEATTACHING：解分配中。 - ATTACHFAIL：分配失败。 - DEATTACHFAIL：解分配失败。 - WAITING：等待被分配中,描述从批量分配（解分配）下发到转入分配（解分配）的中间状态 同时方便单个关联流程的状态独立性。 - ATTACH_FAIL_CAN_ATTACH_AGAIN：分配失败,还可以再关联。 - DEATTACH_FAIL_CAN_DEATTACH_AGAIN：解分配失败,还可以再解分配。
        /// </summary>
        /// <value>分配状态。 - ATTACHED：已分配。 - UNATTACH：未分配 表示未关联。 - DEATTACHED：已解分配。 - ATTACHING：分配中。 - DEATTACHING：解分配中。 - ATTACHFAIL：分配失败。 - DEATTACHFAIL：解分配失败。 - WAITING：等待被分配中,描述从批量分配（解分配）下发到转入分配（解分配）的中间状态 同时方便单个关联流程的状态独立性。 - ATTACH_FAIL_CAN_ATTACH_AGAIN：分配失败,还可以再关联。 - DEATTACH_FAIL_CAN_DEATTACH_AGAIN：解分配失败,还可以再解分配。</value>
        [JsonConverter(typeof(EnumClassConverter<AttachStateEnum>))]
        public class AttachStateEnum
        {
            /// <summary>
            /// Enum ATTACHED for value: ATTACHED
            /// </summary>
            public static readonly AttachStateEnum ATTACHED = new AttachStateEnum("ATTACHED");

            /// <summary>
            /// Enum UNATTACH for value: UNATTACH
            /// </summary>
            public static readonly AttachStateEnum UNATTACH = new AttachStateEnum("UNATTACH");

            /// <summary>
            /// Enum DEATTACHED for value: DEATTACHED
            /// </summary>
            public static readonly AttachStateEnum DEATTACHED = new AttachStateEnum("DEATTACHED");

            /// <summary>
            /// Enum ATTACHING for value: ATTACHING
            /// </summary>
            public static readonly AttachStateEnum ATTACHING = new AttachStateEnum("ATTACHING");

            /// <summary>
            /// Enum DEATTACHING for value: DEATTACHING
            /// </summary>
            public static readonly AttachStateEnum DEATTACHING = new AttachStateEnum("DEATTACHING");

            /// <summary>
            /// Enum ATTACHFAIL for value: ATTACHFAIL
            /// </summary>
            public static readonly AttachStateEnum ATTACHFAIL = new AttachStateEnum("ATTACHFAIL");

            /// <summary>
            /// Enum DEATTACHFAIL for value: DEATTACHFAIL
            /// </summary>
            public static readonly AttachStateEnum DEATTACHFAIL = new AttachStateEnum("DEATTACHFAIL");

            /// <summary>
            /// Enum WAITING for value: WAITING
            /// </summary>
            public static readonly AttachStateEnum WAITING = new AttachStateEnum("WAITING");

            /// <summary>
            /// Enum ATTACH_FAIL_CAN_ATTACH_AGAIN for value: ATTACH_FAIL_CAN_ATTACH_AGAIN
            /// </summary>
            public static readonly AttachStateEnum ATTACH_FAIL_CAN_ATTACH_AGAIN = new AttachStateEnum("ATTACH_FAIL_CAN_ATTACH_AGAIN");

            /// <summary>
            /// Enum DEATTACH_FAIL_CAN_DEATTACH_AGAIN for value: DEATTACH_FAIL_CAN_DEATTACH_AGAIN
            /// </summary>
            public static readonly AttachStateEnum DEATTACH_FAIL_CAN_DEATTACH_AGAIN = new AttachStateEnum("DEATTACH_FAIL_CAN_DEATTACH_AGAIN");

            private static readonly Dictionary<string, AttachStateEnum> StaticFields =
            new Dictionary<string, AttachStateEnum>()
            {
                { "ATTACHED", ATTACHED },
                { "UNATTACH", UNATTACH },
                { "DEATTACHED", DEATTACHED },
                { "ATTACHING", ATTACHING },
                { "DEATTACHING", DEATTACHING },
                { "ATTACHFAIL", ATTACHFAIL },
                { "DEATTACHFAIL", DEATTACHFAIL },
                { "WAITING", WAITING },
                { "ATTACH_FAIL_CAN_ATTACH_AGAIN", ATTACH_FAIL_CAN_ATTACH_AGAIN },
                { "DEATTACH_FAIL_CAN_DEATTACH_AGAIN", DEATTACH_FAIL_CAN_DEATTACH_AGAIN },
            };

            private string _value;

            public AttachStateEnum()
            {

            }

            public AttachStateEnum(string value)
            {
                _value = value;
            }

            public static AttachStateEnum FromValue(string value)
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

                if (this.Equals(obj as AttachStateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AttachStateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AttachStateEnum a, AttachStateEnum b)
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

            public static bool operator !=(AttachStateEnum a, AttachStateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 桌面ID。
        /// </summary>
        [JsonProperty("desktop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopId { get; set; }

        /// <summary>
        /// 桌面名。
        /// </summary>
        [JsonProperty("computer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ComputerName { get; set; }

        /// <summary>
        /// 系统计算机名。
        /// </summary>
        [JsonProperty("os_host_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OsHostName { get; set; }

        /// <summary>
        /// 桌面IP地址列表。
        /// </summary>
        [JsonProperty("addresses", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, List<AddressInfo>> Addresses { get; set; }

        /// <summary>
        /// IP地址列表。
        /// </summary>
        [JsonProperty("ip_addresses", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IpAddresses { get; set; }

        /// <summary>
        /// 系统计算机IPV4。
        /// </summary>
        [JsonProperty("ipv4", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv4 { get; set; }

        /// <summary>
        /// 系统计算机IPV6。
        /// </summary>
        [JsonProperty("ipv6", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv6 { get; set; }

        /// <summary>
        /// 用户列表。
        /// </summary>
        [JsonProperty("user_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UserList { get; set; }

        /// <summary>
        /// 用户组列表。
        /// </summary>
        [JsonProperty("user_group_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UserGroupList { get; set; }

        /// <summary>
        /// 桌面类型。  - DEDICATED：专属桌面。
        /// </summary>
        [JsonProperty("desktop_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopType { get; set; }

        /// <summary>
        /// resource_type字段，分别表示：专属桌面（DEDICATED_DESKTOP）、池桌面（POOLED_DESKTOP）、渲染桌面（RENDER_DESKTOP）、专享主机（EXCLUSIVE_HOST）、多用户桌面(SHARED_DESKTOP)。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 桌面元数据。  - charging_mode 周期套餐标识，1表示包周期，0表示按需。 - image_name 创建桌面的镜像名称。 - bill_resource_id 镜像计费资源ID。 - metering.image_id 镜像ID。 - metering.resourcespeccode 桌面资源编码。 - metering.resourcetype 桌面资源类型。 - os_bit 操作系统位数：32或64。 - os_type 操作系统类型：Linux、Windows或Others。 - desktop_os_version 操作系统版本。
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public FlavorInfo Flavor { get; set; }

        /// <summary>
        /// 桌面状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 任务状态。  - scheduling：创建中，正在进行调度。 - block_device_mapping：创建中，正在准备磁盘。 - networking：创建中，正在准备网络。 - spawning：创建中，正在内部创建。 - rebooting：重启中。 - reboot_pending：重启中，正在下发重启。 - reboot_started：重启中，开始内部重启。 - rebooting_hard：强制重启中。 - reboot_pending_hard：强制重启中，正在下发重启。 - reboot_started_hard：强制重启中，开始内部重启。 - rebuilding：重建中。 - rebuild_block_device_mapping：重建中，正在准备磁盘。 - rebuild_spawning：重建中，正在内部重建。 - migrating：热迁移中。 - resize_prep：调整规格中，正在准备阶段。 - resize_migrating：调整规格中，正在迁移阶段。 - resize_migrated：调整规格中，已经完成迁移。 - resize_finish：调整规格中，正在完成调整。 - resize_reverting：调整规格中，正在回退调整。 - powering-off：停止中。 - powering-on：启动中。 - deleting：删除中。 - deleteFailed：删除失败。 - updating: 更新中。 - desktopNetworkChanging: 切换网络中。
        /// </summary>
        [JsonProperty("task_status", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// 是否处于维护模式,true表示维护模式，false表示不处于维护模式。
        /// </summary>
        [JsonProperty("in_maintenance_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InMaintenanceMode { get; set; }

        /// <summary>
        /// 桌面创建时间。
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// 桌面安全组。
        /// </summary>
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<SecurityGroupInfo> SecurityGroups { get; set; }

        /// <summary>
        /// 桌面的登录状态。  - UNREGISTER：表示桌面未注册时的状态（桌面启动后，会自动注册）。关机后也会出现未注册的状态。 - REGISTERED：表示桌面注册以后，等待用户连接的状态。 - CONNECTED：表示用户已经成功登录，正在使用桌面。 - DISCONNECTED：表示桌面与客户端断开会话后显示的状态，可能为关闭客户端窗口，或客户端与桌面网络断开引起。
        /// </summary>
        [JsonProperty("login_status", NullValueHandling = NullValueHandling.Ignore)]
        public string LoginStatus { get; set; }

        /// <summary>
        /// 桌面所属用户。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 桌面已分配的用户信息列表。
        /// </summary>
        [JsonProperty("attach_user_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<AttachInstancesUserInfo> AttachUserInfos { get; set; }

        /// <summary>
        /// 产品ID。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 桌面协同资源SKU码。
        /// </summary>
        [JsonProperty("share_resource_sku", NullValueHandling = NullValueHandling.Ignore)]
        public string ShareResourceSku { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("root_volume", NullValueHandling = NullValueHandling.Ignore)]
        public VolumeDetail RootVolume { get; set; }

        /// <summary>
        /// 数据盘列表。
        /// </summary>
        [JsonProperty("data_volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<VolumeDetail> DataVolumes { get; set; }

        /// <summary>
        /// 桌面用户所属的用户组。  - sudo：Linux管理员组。 - default：Linux默认用户组。 - administrators：Windows管理员组。管理员拥有对该桌面的完全访问权，可以做任何需要的更改（禁用操作除外）。 - users：Windows标准用户组。标准用户可以使用大多数软件，并可以更改不影响其他用户的系统设置。
        /// </summary>
        [JsonProperty("user_group", NullValueHandling = NullValueHandling.Ignore)]
        public string UserGroup { get; set; }

        /// <summary>
        /// 可用分区。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 站点类型。
        /// </summary>
        [JsonProperty("site_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteType { get; set; }

        /// <summary>
        /// 站点名字。
        /// </summary>
        [JsonProperty("site_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("product", NullValueHandling = NullValueHandling.Ignore)]
        public ProductInfo Product { get; set; }

        /// <summary>
        /// 创建桌面时加入的OU名称。
        /// </summary>
        [JsonProperty("ou_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OuName { get; set; }

        /// <summary>
        /// 操作系统版本号。
        /// </summary>
        [JsonProperty("os_version", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVersion { get; set; }

        /// <summary>
        /// SID。
        /// </summary>
        [JsonProperty("sid", NullValueHandling = NullValueHandling.Ignore)]
        public string Sid { get; set; }

        /// <summary>
        /// 包周期产品的订单ID。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 桌面标签列表。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 是否开通互联网，true：已开通，false：未开通。
        /// </summary>
        [JsonProperty("is_support_internet", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportInternet { get; set; }

        /// <summary>
        /// 上网方式。 - NAT：表示NAT上网方式。 - EIP：表示EIP上网方式。 - BOTH：表示两种上网方式都支持。
        /// </summary>
        [JsonProperty("internet_mode", NullValueHandling = NullValueHandling.Ignore)]
        public InternetModeEnum InternetMode { get; set; }
        /// <summary>
        /// 桌面使用的上网方式列表。
        /// </summary>
        [JsonProperty("internet_mode_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InternetModeList { get; set; }

        /// <summary>
        /// 桌面是否正在绑定EIP。
        /// </summary>
        [JsonProperty("is_attaching_eip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAttachingEip { get; set; }

        /// <summary>
        /// 分配状态。 - ATTACHED：已分配。 - UNATTACH：未分配 表示未关联。 - DEATTACHED：已解分配。 - ATTACHING：分配中。 - DEATTACHING：解分配中。 - ATTACHFAIL：分配失败。 - DEATTACHFAIL：解分配失败。 - WAITING：等待被分配中,描述从批量分配（解分配）下发到转入分配（解分配）的中间状态 同时方便单个关联流程的状态独立性。 - ATTACH_FAIL_CAN_ATTACH_AGAIN：分配失败,还可以再关联。 - DEATTACH_FAIL_CAN_DEATTACH_AGAIN：解分配失败,还可以再解分配。
        /// </summary>
        [JsonProperty("attach_state", NullValueHandling = NullValueHandling.Ignore)]
        public AttachStateEnum AttachState { get; set; }
        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 桌面的子网ID。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 桌面计费资源ID。
        /// </summary>
        [JsonProperty("bill_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BillResourceId { get; set; }

        /// <summary>
        /// 桌面任务进度， 取值范围0-100以及null，null表示该桌面无任务，0-100表明该任务进度的百分比。
        /// </summary>
        [JsonProperty("process", NullValueHandling = NullValueHandling.Ignore)]
        public int? Process { get; set; }

        /// <summary>
        /// 整机实例根资源ID。
        /// </summary>
        [JsonProperty("root_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RootResourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hour_package_info", NullValueHandling = NullValueHandling.Ignore)]
        public HourPackageInfo HourPackageInfo { get; set; }

        /// <summary>
        /// 桌面与桌面池不一致的规格类型: - PRODUCT: 产品ID不一致 - IMAGE: 镜像ID不一致
        /// </summary>
        [JsonProperty("inconsistent_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InconsistentTypes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoolDesktopsDetailInfo {\n");
            sb.Append("  desktopId: ").Append(DesktopId).Append("\n");
            sb.Append("  computerName: ").Append(ComputerName).Append("\n");
            sb.Append("  osHostName: ").Append(OsHostName).Append("\n");
            sb.Append("  addresses: ").Append(Addresses).Append("\n");
            sb.Append("  ipAddresses: ").Append(IpAddresses).Append("\n");
            sb.Append("  ipv4: ").Append(Ipv4).Append("\n");
            sb.Append("  ipv6: ").Append(Ipv6).Append("\n");
            sb.Append("  userList: ").Append(UserList).Append("\n");
            sb.Append("  userGroupList: ").Append(UserGroupList).Append("\n");
            sb.Append("  desktopType: ").Append(DesktopType).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  taskStatus: ").Append(TaskStatus).Append("\n");
            sb.Append("  inMaintenanceMode: ").Append(InMaintenanceMode).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  loginStatus: ").Append(LoginStatus).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  attachUserInfos: ").Append(AttachUserInfos).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  shareResourceSku: ").Append(ShareResourceSku).Append("\n");
            sb.Append("  rootVolume: ").Append(RootVolume).Append("\n");
            sb.Append("  dataVolumes: ").Append(DataVolumes).Append("\n");
            sb.Append("  userGroup: ").Append(UserGroup).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  siteType: ").Append(SiteType).Append("\n");
            sb.Append("  siteName: ").Append(SiteName).Append("\n");
            sb.Append("  product: ").Append(Product).Append("\n");
            sb.Append("  ouName: ").Append(OuName).Append("\n");
            sb.Append("  osVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  sid: ").Append(Sid).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  isSupportInternet: ").Append(IsSupportInternet).Append("\n");
            sb.Append("  internetMode: ").Append(InternetMode).Append("\n");
            sb.Append("  internetModeList: ").Append(InternetModeList).Append("\n");
            sb.Append("  isAttachingEip: ").Append(IsAttachingEip).Append("\n");
            sb.Append("  attachState: ").Append(AttachState).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  billResourceId: ").Append(BillResourceId).Append("\n");
            sb.Append("  process: ").Append(Process).Append("\n");
            sb.Append("  rootResourceId: ").Append(RootResourceId).Append("\n");
            sb.Append("  hourPackageInfo: ").Append(HourPackageInfo).Append("\n");
            sb.Append("  inconsistentTypes: ").Append(InconsistentTypes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoolDesktopsDetailInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoolDesktopsDetailInfo input)
        {
            if (input == null) return false;
            if (this.DesktopId != input.DesktopId || (this.DesktopId != null && !this.DesktopId.Equals(input.DesktopId))) return false;
            if (this.ComputerName != input.ComputerName || (this.ComputerName != null && !this.ComputerName.Equals(input.ComputerName))) return false;
            if (this.OsHostName != input.OsHostName || (this.OsHostName != null && !this.OsHostName.Equals(input.OsHostName))) return false;
            if (this.Addresses != input.Addresses || (this.Addresses != null && input.Addresses != null && !this.Addresses.SequenceEqual(input.Addresses))) return false;
            if (this.IpAddresses != input.IpAddresses || (this.IpAddresses != null && input.IpAddresses != null && !this.IpAddresses.SequenceEqual(input.IpAddresses))) return false;
            if (this.Ipv4 != input.Ipv4 || (this.Ipv4 != null && !this.Ipv4.Equals(input.Ipv4))) return false;
            if (this.Ipv6 != input.Ipv6 || (this.Ipv6 != null && !this.Ipv6.Equals(input.Ipv6))) return false;
            if (this.UserList != input.UserList || (this.UserList != null && input.UserList != null && !this.UserList.SequenceEqual(input.UserList))) return false;
            if (this.UserGroupList != input.UserGroupList || (this.UserGroupList != null && input.UserGroupList != null && !this.UserGroupList.SequenceEqual(input.UserGroupList))) return false;
            if (this.DesktopType != input.DesktopType || (this.DesktopType != null && !this.DesktopType.Equals(input.DesktopType))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && input.Metadata != null && !this.Metadata.SequenceEqual(input.Metadata))) return false;
            if (this.Flavor != input.Flavor || (this.Flavor != null && !this.Flavor.Equals(input.Flavor))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.TaskStatus != input.TaskStatus || (this.TaskStatus != null && !this.TaskStatus.Equals(input.TaskStatus))) return false;
            if (this.InMaintenanceMode != input.InMaintenanceMode || (this.InMaintenanceMode != null && !this.InMaintenanceMode.Equals(input.InMaintenanceMode))) return false;
            if (this.Created != input.Created || (this.Created != null && !this.Created.Equals(input.Created))) return false;
            if (this.SecurityGroups != input.SecurityGroups || (this.SecurityGroups != null && input.SecurityGroups != null && !this.SecurityGroups.SequenceEqual(input.SecurityGroups))) return false;
            if (this.LoginStatus != input.LoginStatus || (this.LoginStatus != null && !this.LoginStatus.Equals(input.LoginStatus))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.AttachUserInfos != input.AttachUserInfos || (this.AttachUserInfos != null && input.AttachUserInfos != null && !this.AttachUserInfos.SequenceEqual(input.AttachUserInfos))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.ShareResourceSku != input.ShareResourceSku || (this.ShareResourceSku != null && !this.ShareResourceSku.Equals(input.ShareResourceSku))) return false;
            if (this.RootVolume != input.RootVolume || (this.RootVolume != null && !this.RootVolume.Equals(input.RootVolume))) return false;
            if (this.DataVolumes != input.DataVolumes || (this.DataVolumes != null && input.DataVolumes != null && !this.DataVolumes.SequenceEqual(input.DataVolumes))) return false;
            if (this.UserGroup != input.UserGroup || (this.UserGroup != null && !this.UserGroup.Equals(input.UserGroup))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.SiteType != input.SiteType || (this.SiteType != null && !this.SiteType.Equals(input.SiteType))) return false;
            if (this.SiteName != input.SiteName || (this.SiteName != null && !this.SiteName.Equals(input.SiteName))) return false;
            if (this.Product != input.Product || (this.Product != null && !this.Product.Equals(input.Product))) return false;
            if (this.OuName != input.OuName || (this.OuName != null && !this.OuName.Equals(input.OuName))) return false;
            if (this.OsVersion != input.OsVersion || (this.OsVersion != null && !this.OsVersion.Equals(input.OsVersion))) return false;
            if (this.Sid != input.Sid || (this.Sid != null && !this.Sid.Equals(input.Sid))) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.IsSupportInternet != input.IsSupportInternet || (this.IsSupportInternet != null && !this.IsSupportInternet.Equals(input.IsSupportInternet))) return false;
            if (this.InternetMode != input.InternetMode) return false;
            if (this.InternetModeList != input.InternetModeList || (this.InternetModeList != null && input.InternetModeList != null && !this.InternetModeList.SequenceEqual(input.InternetModeList))) return false;
            if (this.IsAttachingEip != input.IsAttachingEip || (this.IsAttachingEip != null && !this.IsAttachingEip.Equals(input.IsAttachingEip))) return false;
            if (this.AttachState != input.AttachState) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.BillResourceId != input.BillResourceId || (this.BillResourceId != null && !this.BillResourceId.Equals(input.BillResourceId))) return false;
            if (this.Process != input.Process || (this.Process != null && !this.Process.Equals(input.Process))) return false;
            if (this.RootResourceId != input.RootResourceId || (this.RootResourceId != null && !this.RootResourceId.Equals(input.RootResourceId))) return false;
            if (this.HourPackageInfo != input.HourPackageInfo || (this.HourPackageInfo != null && !this.HourPackageInfo.Equals(input.HourPackageInfo))) return false;
            if (this.InconsistentTypes != input.InconsistentTypes || (this.InconsistentTypes != null && input.InconsistentTypes != null && !this.InconsistentTypes.SequenceEqual(input.InconsistentTypes))) return false;

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
                if (this.DesktopId != null) hashCode = hashCode * 59 + this.DesktopId.GetHashCode();
                if (this.ComputerName != null) hashCode = hashCode * 59 + this.ComputerName.GetHashCode();
                if (this.OsHostName != null) hashCode = hashCode * 59 + this.OsHostName.GetHashCode();
                if (this.Addresses != null) hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.IpAddresses != null) hashCode = hashCode * 59 + this.IpAddresses.GetHashCode();
                if (this.Ipv4 != null) hashCode = hashCode * 59 + this.Ipv4.GetHashCode();
                if (this.Ipv6 != null) hashCode = hashCode * 59 + this.Ipv6.GetHashCode();
                if (this.UserList != null) hashCode = hashCode * 59 + this.UserList.GetHashCode();
                if (this.UserGroupList != null) hashCode = hashCode * 59 + this.UserGroupList.GetHashCode();
                if (this.DesktopType != null) hashCode = hashCode * 59 + this.DesktopType.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Flavor != null) hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TaskStatus != null) hashCode = hashCode * 59 + this.TaskStatus.GetHashCode();
                if (this.InMaintenanceMode != null) hashCode = hashCode * 59 + this.InMaintenanceMode.GetHashCode();
                if (this.Created != null) hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.SecurityGroups != null) hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.LoginStatus != null) hashCode = hashCode * 59 + this.LoginStatus.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.AttachUserInfos != null) hashCode = hashCode * 59 + this.AttachUserInfos.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.ShareResourceSku != null) hashCode = hashCode * 59 + this.ShareResourceSku.GetHashCode();
                if (this.RootVolume != null) hashCode = hashCode * 59 + this.RootVolume.GetHashCode();
                if (this.DataVolumes != null) hashCode = hashCode * 59 + this.DataVolumes.GetHashCode();
                if (this.UserGroup != null) hashCode = hashCode * 59 + this.UserGroup.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.SiteType != null) hashCode = hashCode * 59 + this.SiteType.GetHashCode();
                if (this.SiteName != null) hashCode = hashCode * 59 + this.SiteName.GetHashCode();
                if (this.Product != null) hashCode = hashCode * 59 + this.Product.GetHashCode();
                if (this.OuName != null) hashCode = hashCode * 59 + this.OuName.GetHashCode();
                if (this.OsVersion != null) hashCode = hashCode * 59 + this.OsVersion.GetHashCode();
                if (this.Sid != null) hashCode = hashCode * 59 + this.Sid.GetHashCode();
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.IsSupportInternet != null) hashCode = hashCode * 59 + this.IsSupportInternet.GetHashCode();
                hashCode = hashCode * 59 + this.InternetMode.GetHashCode();
                if (this.InternetModeList != null) hashCode = hashCode * 59 + this.InternetModeList.GetHashCode();
                if (this.IsAttachingEip != null) hashCode = hashCode * 59 + this.IsAttachingEip.GetHashCode();
                hashCode = hashCode * 59 + this.AttachState.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.BillResourceId != null) hashCode = hashCode * 59 + this.BillResourceId.GetHashCode();
                if (this.Process != null) hashCode = hashCode * 59 + this.Process.GetHashCode();
                if (this.RootResourceId != null) hashCode = hashCode * 59 + this.RootResourceId.GetHashCode();
                if (this.HourPackageInfo != null) hashCode = hashCode * 59 + this.HourPackageInfo.GetHashCode();
                if (this.InconsistentTypes != null) hashCode = hashCode * 59 + this.InconsistentTypes.GetHashCode();
                return hashCode;
            }
        }
    }
}
