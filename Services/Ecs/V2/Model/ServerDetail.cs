using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 云服务器详情。
    /// </summary>
    public class ServerDetail 
    {

        /// <summary>
        /// 弹性云服务器状态。  取值范围：  ACTIVE、BUILD、DELETED、ERROR、HARD_REBOOT、MIGRATING、PAUSED、REBOOT、REBUILD、RESIZE、REVERT_RESIZE、SHUTOFF、SHELVED、SHELVED_OFFLOADED、SOFT_DELETED、SUSPENDED、VERIFY_RESIZE  弹性云服务器状态说明请参考[云服务器状态](https://support.huaweicloud.com/api-ecs/ecs_08_0002.html)
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 弹性云服务器更新时间。  时间格式例如：2019-05-22T03:30:52Z
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        /// <summary>
        /// 弹性云服务器自动释放时间。  时间格式例如：2020-01-19T03:30:52Z
        /// </summary>
        [JsonProperty("auto_terminate_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AutoTerminateTime { get; set; }

        /// <summary>
        /// 弹性云服务器所在主机的主机ID。
        /// </summary>
        [JsonProperty("hostId", NullValueHandling = NullValueHandling.Ignore)]
        public string HostId { get; set; }

        /// <summary>
        /// 弹性云服务器所在主机的主机名称。
        /// </summary>
        [JsonProperty("OS-EXT-SRV-ATTR:host", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTSRVATTRhost { get; set; }

        /// <summary>
        /// 弹性云服务器的网络属性。
        /// </summary>
        [JsonProperty("addresses", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, List<ServerAddress>> Addresses { get; set; }

        /// <summary>
        /// 弹性云服务器使用的密钥对名称。
        /// </summary>
        [JsonProperty("key_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public ServerImage Image { get; set; }

        /// <summary>
        /// 扩展属性，弹性云服务器当前任务的状态。  取值范围请参考[云服务器状态](https://support.huaweicloud.com/api-ecs/ecs_08_0002.html)表3。
        /// </summary>
        [JsonProperty("OS-EXT-STS:task_state", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTSTStaskState { get; set; }

        /// <summary>
        /// 扩展属性，弹性云服务器当前状态。  云服务器状态说明请参考[云服务器状态](https://support.huaweicloud.com/api-ecs/ecs_08_0002.html)。
        /// </summary>
        [JsonProperty("OS-EXT-STS:vm_state", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTSTSvmState { get; set; }

        /// <summary>
        /// 扩展属性，弹性云服务器别名。
        /// </summary>
        [JsonProperty("OS-EXT-SRV-ATTR:instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTSRVATTRinstanceName { get; set; }

        /// <summary>
        /// 扩展属性，弹性云服务器所在虚拟化主机名。
        /// </summary>
        [JsonProperty("OS-EXT-SRV-ATTR:hypervisor_hostname", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTSRVATTRhypervisorHostname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public ServerFlavor Flavor { get; set; }

        /// <summary>
        /// 弹性云服务器ID，格式为UUID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 弹性云服务器所属安全组列表。
        /// </summary>
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServerSecurityGroup> SecurityGroups { get; set; }

        /// <summary>
        /// 扩展属性，弹性云服务器所在可用区名称。
        /// </summary>
        [JsonProperty("OS-EXT-AZ:availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTAZavailabilityZone { get; set; }

        /// <summary>
        /// 创建弹性云服务器的用户ID，格式为UUID。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 弹性云服务器名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 弹性云服务器创建时间。  时间格式例如：2019-05-22T03:19:19Z
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// 弹性云服务器所属租户ID，即项目id，和project_id表示相同的概念，格式为UUID。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 扩展属性， diskConfig的类型。  - MANUAL，镜像空间不会扩展。 - AUTO，系统盘镜像空间会自动扩展为与flavor大小一致。
        /// </summary>
        [JsonProperty("OS-DCF:diskConfig", NullValueHandling = NullValueHandling.Ignore)]
        public string OSDCFdiskConfig { get; set; }

        /// <summary>
        /// 预留属性。
        /// </summary>
        [JsonProperty("accessIPv4", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessIPv4 { get; set; }

        /// <summary>
        /// 预留属性。
        /// </summary>
        [JsonProperty("accessIPv6", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessIPv6 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fault", NullValueHandling = NullValueHandling.Ignore)]
        public ServerFault Fault { get; set; }

        /// <summary>
        /// 弹性云服务器进度。
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public int? Progress { get; set; }

        /// <summary>
        /// 扩展属性，弹性云服务器电源状态。
        /// </summary>
        [JsonProperty("OS-EXT-STS:power_state", NullValueHandling = NullValueHandling.Ignore)]
        public int? OSEXTSTSpowerState { get; set; }

        /// <summary>
        /// config drive信息。
        /// </summary>
        [JsonProperty("config_drive", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigDrive { get; set; }

        /// <summary>
        /// 弹性云服务器元数据。  &gt; 说明： &gt;  &gt; 元数据包含系统默认添加字段和用户设置的字段。  系统默认添加字段  1. charging_mode 云服务器的计费类型。  - “0”：按需计费（即postPaid-后付费方式）。 - “1”：按包年包月计费（即prePaid-预付费方式）。\&quot;2\&quot;：竞价实例计费  2. metering.order_id 按“包年/包月”计费的云服务器对应的订单ID。  3. metering.product_id 按“包年/包月”计费的云服务器对应的产品ID。  4. vpc_id 云服务器所属的虚拟私有云ID。  5. EcmResStatus 云服务器的冻结状态。  - normal：云服务器正常状态（未被冻结）。 - freeze：云服务器被冻结。  &gt; 当云服务器被冻结或者解冻后，系统默认添加该字段，且该字段必选。  6. metering.image_id 云服务器操作系统对应的镜像ID  7.  metering.imagetype 镜像类型，目前支持：  - 公共镜像（gold） - 私有镜像（private） - 共享镜像（shared）  8. metering.resourcespeccode 云服务器对应的资源规格。  9. image_name 云服务器操作系统对应的镜像名称。  10. os_bit 操作系统位数，一般取值为“32”或者“64”。  11. lockCheckEndpoint 回调URL，用于检查弹性云服务器的加锁是否有效。  - 如果有效，则云服务器保持锁定状态。 - 如果无效，解除锁定状态，删除失效的锁。  12. lockSource 弹性云服务器来自哪个服务。订单加锁（ORDER）  13. lockSourceId 弹性云服务器的加锁来自哪个ID。lockSource为“ORDER”时，lockSourceId为订单ID。  14. lockScene 弹性云服务器的加锁类型。  - 按需转包周期（TO_PERIOD_LOCK）  15. virtual_env_type  - IOS镜像创建虚拟机，\&quot;virtual_env_type\&quot;: \&quot;IsoImage\&quot; 属性； - 非IOS镜像创建虚拟机，在19.5.0版本以后创建的虚拟机将不会添加virtual_env_type 属性，而在此之前的版本创建的虚拟机可能会返回\&quot;virtual_env_type\&quot;: \&quot;FusionCompute\&quot;属性 。  &gt; virtual_env_type属性不允许用户增加、删除和修改。  16. metering.resourcetype 云服务器对应的资源类型。  17. os_type 操作系统类型，取值为：Linux、Windows。  18. cascaded.instance_extrainfo 系统内部虚拟机扩展信息。  19. __support_agent_list 云服务器是否支持企业主机安全、主机监控。  - “hss”：企业主机安全 -  “ces”：主机监控  20. agency_name 委托的名称。  委托是由租户管理员在统一身份认证服务（Identity and Access Management，IAM）上创建的，可以为弹性云服务器提供访问云服务的临时凭证。
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// 弹性云服务器启动时间。时间格式例如：2019-05-22T03:23:59.000000
        /// </summary>
        [JsonProperty("OS-SRV-USG:launched_at", NullValueHandling = NullValueHandling.Ignore)]
        public string OSSRVUSGlaunchedAt { get; set; }

        /// <summary>
        /// 弹性云服务器删除时间。  时间格式例如：2019-05-22T03:23:59.000000
        /// </summary>
        [JsonProperty("OS-SRV-USG:terminated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string OSSRVUSGterminatedAt { get; set; }

        /// <summary>
        /// 挂载到弹性云服务器上的磁盘。
        /// </summary>
        [JsonProperty("os-extended-volumes:volumes_attached", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServerExtendVolumeAttachment> OsExtendedVolumesvolumesAttached { get; set; }

        /// <summary>
        /// 弹性云服务器的描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// nova-compute状态。  - UP：服务正常 - UNKNOWN：状态未知 - DOWN：服务异常 - MAINTENANCE：维护状态 - 空字符串：弹性云服务器无主机信息
        /// </summary>
        [JsonProperty("host_status", NullValueHandling = NullValueHandling.Ignore)]
        public string HostStatus { get; set; }

        /// <summary>
        /// 弹性云服务器的主机名。
        /// </summary>
        [JsonProperty("OS-EXT-SRV-ATTR:hostname", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTSRVATTRhostname { get; set; }

        /// <summary>
        /// 批量创建场景，弹性云服务器的预留ID。
        /// </summary>
        [JsonProperty("OS-EXT-SRV-ATTR:reservation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTSRVATTRreservationId { get; set; }

        /// <summary>
        /// 批量创建场景，弹性云服务器的启动顺序。
        /// </summary>
        [JsonProperty("OS-EXT-SRV-ATTR:launch_index", NullValueHandling = NullValueHandling.Ignore)]
        public int? OSEXTSRVATTRlaunchIndex { get; set; }

        /// <summary>
        /// 若使用AMI格式的镜像，则表示kernel image的UUID；否则，留空。
        /// </summary>
        [JsonProperty("OS-EXT-SRV-ATTR:kernel_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTSRVATTRkernelId { get; set; }

        /// <summary>
        /// 若使用AMI格式镜像，则表示ramdisk image的UUID；否则，留空。
        /// </summary>
        [JsonProperty("OS-EXT-SRV-ATTR:ramdisk_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTSRVATTRramdiskId { get; set; }

        /// <summary>
        /// 弹性云服务器系统盘的设备名称。
        /// </summary>
        [JsonProperty("OS-EXT-SRV-ATTR:root_device_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTSRVATTRrootDeviceName { get; set; }

        /// <summary>
        /// 创建弹性云服务器时指定的user_data。
        /// </summary>
        [JsonProperty("OS-EXT-SRV-ATTR:user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTSRVATTRuserData { get; set; }

        /// <summary>
        /// 弹性云服务器是否为锁定状态。  - true：锁定 - false：未锁定
        /// </summary>
        [JsonProperty("locked", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Locked { get; set; }

        /// <summary>
        /// 弹性云服务器标签。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("os:scheduler_hints", NullValueHandling = NullValueHandling.Ignore)]
        public ServerSchedulerHints OsschedulerHints { get; set; }

        /// <summary>
        /// 弹性云服务器所属的企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 弹性云服务器系统标签。
        /// </summary>
        [JsonProperty("sys_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServerSystemTag> SysTags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cpu_options", NullValueHandling = NullValueHandling.Ignore)]
        public CpuOptions CpuOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hypervisor", NullValueHandling = NullValueHandling.Ignore)]
        public Hypervisor Hypervisor { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerDetail {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("  autoTerminateTime: ").Append(AutoTerminateTime).Append("\n");
            sb.Append("  hostId: ").Append(HostId).Append("\n");
            sb.Append("  oSEXTSRVATTRhost: ").Append(OSEXTSRVATTRhost).Append("\n");
            sb.Append("  addresses: ").Append(Addresses).Append("\n");
            sb.Append("  keyName: ").Append(KeyName).Append("\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  oSEXTSTStaskState: ").Append(OSEXTSTStaskState).Append("\n");
            sb.Append("  oSEXTSTSvmState: ").Append(OSEXTSTSvmState).Append("\n");
            sb.Append("  oSEXTSRVATTRinstanceName: ").Append(OSEXTSRVATTRinstanceName).Append("\n");
            sb.Append("  oSEXTSRVATTRhypervisorHostname: ").Append(OSEXTSRVATTRhypervisorHostname).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  oSEXTAZavailabilityZone: ").Append(OSEXTAZavailabilityZone).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  oSDCFdiskConfig: ").Append(OSDCFdiskConfig).Append("\n");
            sb.Append("  accessIPv4: ").Append(AccessIPv4).Append("\n");
            sb.Append("  accessIPv6: ").Append(AccessIPv6).Append("\n");
            sb.Append("  fault: ").Append(Fault).Append("\n");
            sb.Append("  progress: ").Append(Progress).Append("\n");
            sb.Append("  oSEXTSTSpowerState: ").Append(OSEXTSTSpowerState).Append("\n");
            sb.Append("  configDrive: ").Append(ConfigDrive).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  oSSRVUSGlaunchedAt: ").Append(OSSRVUSGlaunchedAt).Append("\n");
            sb.Append("  oSSRVUSGterminatedAt: ").Append(OSSRVUSGterminatedAt).Append("\n");
            sb.Append("  osExtendedVolumesvolumesAttached: ").Append(OsExtendedVolumesvolumesAttached).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  hostStatus: ").Append(HostStatus).Append("\n");
            sb.Append("  oSEXTSRVATTRhostname: ").Append(OSEXTSRVATTRhostname).Append("\n");
            sb.Append("  oSEXTSRVATTRreservationId: ").Append(OSEXTSRVATTRreservationId).Append("\n");
            sb.Append("  oSEXTSRVATTRlaunchIndex: ").Append(OSEXTSRVATTRlaunchIndex).Append("\n");
            sb.Append("  oSEXTSRVATTRkernelId: ").Append(OSEXTSRVATTRkernelId).Append("\n");
            sb.Append("  oSEXTSRVATTRramdiskId: ").Append(OSEXTSRVATTRramdiskId).Append("\n");
            sb.Append("  oSEXTSRVATTRrootDeviceName: ").Append(OSEXTSRVATTRrootDeviceName).Append("\n");
            sb.Append("  oSEXTSRVATTRuserData: ").Append(OSEXTSRVATTRuserData).Append("\n");
            sb.Append("  locked: ").Append(Locked).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  osschedulerHints: ").Append(OsschedulerHints).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  sysTags: ").Append(SysTags).Append("\n");
            sb.Append("  cpuOptions: ").Append(CpuOptions).Append("\n");
            sb.Append("  hypervisor: ").Append(Hypervisor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerDetail input)
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
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
                ) && 
                (
                    this.AutoTerminateTime == input.AutoTerminateTime ||
                    (this.AutoTerminateTime != null &&
                    this.AutoTerminateTime.Equals(input.AutoTerminateTime))
                ) && 
                (
                    this.HostId == input.HostId ||
                    (this.HostId != null &&
                    this.HostId.Equals(input.HostId))
                ) && 
                (
                    this.OSEXTSRVATTRhost == input.OSEXTSRVATTRhost ||
                    (this.OSEXTSRVATTRhost != null &&
                    this.OSEXTSRVATTRhost.Equals(input.OSEXTSRVATTRhost))
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.KeyName == input.KeyName ||
                    (this.KeyName != null &&
                    this.KeyName.Equals(input.KeyName))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.OSEXTSTStaskState == input.OSEXTSTStaskState ||
                    (this.OSEXTSTStaskState != null &&
                    this.OSEXTSTStaskState.Equals(input.OSEXTSTStaskState))
                ) && 
                (
                    this.OSEXTSTSvmState == input.OSEXTSTSvmState ||
                    (this.OSEXTSTSvmState != null &&
                    this.OSEXTSTSvmState.Equals(input.OSEXTSTSvmState))
                ) && 
                (
                    this.OSEXTSRVATTRinstanceName == input.OSEXTSRVATTRinstanceName ||
                    (this.OSEXTSRVATTRinstanceName != null &&
                    this.OSEXTSRVATTRinstanceName.Equals(input.OSEXTSRVATTRinstanceName))
                ) && 
                (
                    this.OSEXTSRVATTRhypervisorHostname == input.OSEXTSRVATTRhypervisorHostname ||
                    (this.OSEXTSRVATTRhypervisorHostname != null &&
                    this.OSEXTSRVATTRhypervisorHostname.Equals(input.OSEXTSRVATTRhypervisorHostname))
                ) && 
                (
                    this.Flavor == input.Flavor ||
                    (this.Flavor != null &&
                    this.Flavor.Equals(input.Flavor))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.SecurityGroups == input.SecurityGroups ||
                    this.SecurityGroups != null &&
                    input.SecurityGroups != null &&
                    this.SecurityGroups.SequenceEqual(input.SecurityGroups)
                ) && 
                (
                    this.OSEXTAZavailabilityZone == input.OSEXTAZavailabilityZone ||
                    (this.OSEXTAZavailabilityZone != null &&
                    this.OSEXTAZavailabilityZone.Equals(input.OSEXTAZavailabilityZone))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.OSDCFdiskConfig == input.OSDCFdiskConfig ||
                    (this.OSDCFdiskConfig != null &&
                    this.OSDCFdiskConfig.Equals(input.OSDCFdiskConfig))
                ) && 
                (
                    this.AccessIPv4 == input.AccessIPv4 ||
                    (this.AccessIPv4 != null &&
                    this.AccessIPv4.Equals(input.AccessIPv4))
                ) && 
                (
                    this.AccessIPv6 == input.AccessIPv6 ||
                    (this.AccessIPv6 != null &&
                    this.AccessIPv6.Equals(input.AccessIPv6))
                ) && 
                (
                    this.Fault == input.Fault ||
                    (this.Fault != null &&
                    this.Fault.Equals(input.Fault))
                ) && 
                (
                    this.Progress == input.Progress ||
                    (this.Progress != null &&
                    this.Progress.Equals(input.Progress))
                ) && 
                (
                    this.OSEXTSTSpowerState == input.OSEXTSTSpowerState ||
                    (this.OSEXTSTSpowerState != null &&
                    this.OSEXTSTSpowerState.Equals(input.OSEXTSTSpowerState))
                ) && 
                (
                    this.ConfigDrive == input.ConfigDrive ||
                    (this.ConfigDrive != null &&
                    this.ConfigDrive.Equals(input.ConfigDrive))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.OSSRVUSGlaunchedAt == input.OSSRVUSGlaunchedAt ||
                    (this.OSSRVUSGlaunchedAt != null &&
                    this.OSSRVUSGlaunchedAt.Equals(input.OSSRVUSGlaunchedAt))
                ) && 
                (
                    this.OSSRVUSGterminatedAt == input.OSSRVUSGterminatedAt ||
                    (this.OSSRVUSGterminatedAt != null &&
                    this.OSSRVUSGterminatedAt.Equals(input.OSSRVUSGterminatedAt))
                ) && 
                (
                    this.OsExtendedVolumesvolumesAttached == input.OsExtendedVolumesvolumesAttached ||
                    this.OsExtendedVolumesvolumesAttached != null &&
                    input.OsExtendedVolumesvolumesAttached != null &&
                    this.OsExtendedVolumesvolumesAttached.SequenceEqual(input.OsExtendedVolumesvolumesAttached)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.HostStatus == input.HostStatus ||
                    (this.HostStatus != null &&
                    this.HostStatus.Equals(input.HostStatus))
                ) && 
                (
                    this.OSEXTSRVATTRhostname == input.OSEXTSRVATTRhostname ||
                    (this.OSEXTSRVATTRhostname != null &&
                    this.OSEXTSRVATTRhostname.Equals(input.OSEXTSRVATTRhostname))
                ) && 
                (
                    this.OSEXTSRVATTRreservationId == input.OSEXTSRVATTRreservationId ||
                    (this.OSEXTSRVATTRreservationId != null &&
                    this.OSEXTSRVATTRreservationId.Equals(input.OSEXTSRVATTRreservationId))
                ) && 
                (
                    this.OSEXTSRVATTRlaunchIndex == input.OSEXTSRVATTRlaunchIndex ||
                    (this.OSEXTSRVATTRlaunchIndex != null &&
                    this.OSEXTSRVATTRlaunchIndex.Equals(input.OSEXTSRVATTRlaunchIndex))
                ) && 
                (
                    this.OSEXTSRVATTRkernelId == input.OSEXTSRVATTRkernelId ||
                    (this.OSEXTSRVATTRkernelId != null &&
                    this.OSEXTSRVATTRkernelId.Equals(input.OSEXTSRVATTRkernelId))
                ) && 
                (
                    this.OSEXTSRVATTRramdiskId == input.OSEXTSRVATTRramdiskId ||
                    (this.OSEXTSRVATTRramdiskId != null &&
                    this.OSEXTSRVATTRramdiskId.Equals(input.OSEXTSRVATTRramdiskId))
                ) && 
                (
                    this.OSEXTSRVATTRrootDeviceName == input.OSEXTSRVATTRrootDeviceName ||
                    (this.OSEXTSRVATTRrootDeviceName != null &&
                    this.OSEXTSRVATTRrootDeviceName.Equals(input.OSEXTSRVATTRrootDeviceName))
                ) && 
                (
                    this.OSEXTSRVATTRuserData == input.OSEXTSRVATTRuserData ||
                    (this.OSEXTSRVATTRuserData != null &&
                    this.OSEXTSRVATTRuserData.Equals(input.OSEXTSRVATTRuserData))
                ) && 
                (
                    this.Locked == input.Locked ||
                    (this.Locked != null &&
                    this.Locked.Equals(input.Locked))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.OsschedulerHints == input.OsschedulerHints ||
                    (this.OsschedulerHints != null &&
                    this.OsschedulerHints.Equals(input.OsschedulerHints))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.SysTags == input.SysTags ||
                    this.SysTags != null &&
                    input.SysTags != null &&
                    this.SysTags.SequenceEqual(input.SysTags)
                ) && 
                (
                    this.CpuOptions == input.CpuOptions ||
                    (this.CpuOptions != null &&
                    this.CpuOptions.Equals(input.CpuOptions))
                ) && 
                (
                    this.Hypervisor == input.Hypervisor ||
                    (this.Hypervisor != null &&
                    this.Hypervisor.Equals(input.Hypervisor))
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
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.AutoTerminateTime != null)
                    hashCode = hashCode * 59 + this.AutoTerminateTime.GetHashCode();
                if (this.HostId != null)
                    hashCode = hashCode * 59 + this.HostId.GetHashCode();
                if (this.OSEXTSRVATTRhost != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRhost.GetHashCode();
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.KeyName != null)
                    hashCode = hashCode * 59 + this.KeyName.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.OSEXTSTStaskState != null)
                    hashCode = hashCode * 59 + this.OSEXTSTStaskState.GetHashCode();
                if (this.OSEXTSTSvmState != null)
                    hashCode = hashCode * 59 + this.OSEXTSTSvmState.GetHashCode();
                if (this.OSEXTSRVATTRinstanceName != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRinstanceName.GetHashCode();
                if (this.OSEXTSRVATTRhypervisorHostname != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRhypervisorHostname.GetHashCode();
                if (this.Flavor != null)
                    hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.SecurityGroups != null)
                    hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.OSEXTAZavailabilityZone != null)
                    hashCode = hashCode * 59 + this.OSEXTAZavailabilityZone.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.OSDCFdiskConfig != null)
                    hashCode = hashCode * 59 + this.OSDCFdiskConfig.GetHashCode();
                if (this.AccessIPv4 != null)
                    hashCode = hashCode * 59 + this.AccessIPv4.GetHashCode();
                if (this.AccessIPv6 != null)
                    hashCode = hashCode * 59 + this.AccessIPv6.GetHashCode();
                if (this.Fault != null)
                    hashCode = hashCode * 59 + this.Fault.GetHashCode();
                if (this.Progress != null)
                    hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.OSEXTSTSpowerState != null)
                    hashCode = hashCode * 59 + this.OSEXTSTSpowerState.GetHashCode();
                if (this.ConfigDrive != null)
                    hashCode = hashCode * 59 + this.ConfigDrive.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.OSSRVUSGlaunchedAt != null)
                    hashCode = hashCode * 59 + this.OSSRVUSGlaunchedAt.GetHashCode();
                if (this.OSSRVUSGterminatedAt != null)
                    hashCode = hashCode * 59 + this.OSSRVUSGterminatedAt.GetHashCode();
                if (this.OsExtendedVolumesvolumesAttached != null)
                    hashCode = hashCode * 59 + this.OsExtendedVolumesvolumesAttached.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.HostStatus != null)
                    hashCode = hashCode * 59 + this.HostStatus.GetHashCode();
                if (this.OSEXTSRVATTRhostname != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRhostname.GetHashCode();
                if (this.OSEXTSRVATTRreservationId != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRreservationId.GetHashCode();
                if (this.OSEXTSRVATTRlaunchIndex != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRlaunchIndex.GetHashCode();
                if (this.OSEXTSRVATTRkernelId != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRkernelId.GetHashCode();
                if (this.OSEXTSRVATTRramdiskId != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRramdiskId.GetHashCode();
                if (this.OSEXTSRVATTRrootDeviceName != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRrootDeviceName.GetHashCode();
                if (this.OSEXTSRVATTRuserData != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRuserData.GetHashCode();
                if (this.Locked != null)
                    hashCode = hashCode * 59 + this.Locked.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.OsschedulerHints != null)
                    hashCode = hashCode * 59 + this.OsschedulerHints.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.SysTags != null)
                    hashCode = hashCode * 59 + this.SysTags.GetHashCode();
                if (this.CpuOptions != null)
                    hashCode = hashCode * 59 + this.CpuOptions.GetHashCode();
                if (this.Hypervisor != null)
                    hashCode = hashCode * 59 + this.Hypervisor.GetHashCode();
                return hashCode;
            }
        }
    }
}
