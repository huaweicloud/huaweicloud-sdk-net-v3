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
    /// 云服务器规格的扩展字段。
    /// </summary>
    public class FlavorExtraSpec 
    {

        /// <summary>
        /// 云服务器规格的分类：  - normal：通用型 - entry：通用入门型 - cpuv1：计算I型 - cpuv2：计算II型 - computingv3：通用计算增强型 - kunpeng_computing：鲲鹏通用计算增强型 - kunpeng_highmem：鲲鹏内存优化型 - highmem：内存优化型 - saphana：大内存型 - diskintensive：磁盘增强型 - highio：超高I/O型 - ultracpu：超高性能计算型 - gpu：GPU加速型 - fpga：FPGA加速型 - ascend：AI加速型  &gt; 说明：  - 早期注册的规格该字段为hws:performancetype。
        /// </summary>
        [JsonProperty("ecs:performancetype", NullValueHandling = NullValueHandling.Ignore)]
        public string Ecsperformancetype { get; set; }

        /// <summary>
        /// 主机的物理cpu数量。
        /// </summary>
        [JsonProperty("hw:numa_nodes", NullValueHandling = NullValueHandling.Ignore)]
        public string HwnumaNodes { get; set; }

        /// <summary>
        /// 资源类型。resource_type是为了区分云服务器的物理主机类型。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 弹性运服务器高精度时钟是否开启，开启为true，否则为false。（该字段是否返回根据云服务器规格而定）
        /// </summary>
        [JsonProperty("hpet_support", NullValueHandling = NullValueHandling.Ignore)]
        public string HpetSupport { get; set; }

        /// <summary>
        /// 网卡类型，值固定为“enhanced”，表示使用增强型网络的资源创建云服务器。
        /// </summary>
        [JsonProperty("instance_vnic:type", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceVnictype { get; set; }

        /// <summary>
        /// 最大带宽，单位Mbps，最大值为10000。
        /// </summary>
        [JsonProperty("instance_vnic:instance_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceVnicinstanceBandwidth { get; set; }

        /// <summary>
        /// 最大网卡个数，最大为4。
        /// </summary>
        [JsonProperty("instance_vnic:max_count", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceVnicmaxCount { get; set; }

        /// <summary>
        /// 值格式为{type}:{count}:{size}:{safeFormat}，其中：  - type指磁盘类型，当前只支持hdd。 - count指本地磁盘数量，目前支持d1类型：3/6/12/24，d2类型：2/4/8/12/16/24，d3类型：2/4/8/12/16/24/28。 - size指单个磁盘容量，单位GB，目前只支持1675（实际磁盘大小为1800，格式化后可用大小为1675）。 - safeFormat指云服务器本地磁盘是否安全格式化，目前仅支持d1类型：FALSE，d2/d3类型：True。  &gt; 说明：  - 磁盘增强型特有字段。
        /// </summary>
        [JsonProperty("quota:local_disk", NullValueHandling = NullValueHandling.Ignore)]
        public string QuotalocalDisk { get; set; }

        /// <summary>
        /// 值格式为{type}:{spec}:{size}:{safeFormat}，其中：  - type指主机上配备的nvme ssd的单卡容量大小，当前只支持1.6T/3.2T。 - spec指nvme ssd的规格，包括large/small。large表示大规格，small表示小规格。目前仅支持i3类型：large。 - size指guest使用的盘的容量大小，单位为GB。在spec值为large的情况下，此项即为host单卡大小。在spec值为small的情况下，此为1/4规格或者1/2规格。 - safeFormat指云服务器本地磁盘是否安全格式化，目前仅支持i3类型：True。  &gt; 说明：  - 超高I/O型特有字段。
        /// </summary>
        [JsonProperty("quota:nvme_ssd", NullValueHandling = NullValueHandling.Ignore)]
        public string QuotanvmeSsd { get; set; }

        /// <summary>
        /// 是否支持持久化，值为true。  代表云服务器访问存储的方式为持久化授权。   &gt; 说明：  - 密集存储D1型特有字段。
        /// </summary>
        [JsonProperty("extra_spec:io:persistent_grant", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtraSpeciopersistentGrant { get; set; }

        /// <summary>
        /// 弹性云服务器类型的代数。  - s1：通用型I代 - s2：通用型II代 - s3：通用型 - m1：内存优化型I代 - m2：内存优化型II代 - m3：内存优化型 - h1：高性能计算型I代 - h2：高性能计算型II代 - h3：高性能计算型 - hi3：超高性能计算型 - d1：密集存储型I代 - d2：密集存储型II代 - d3：磁盘增强型 - g1：GPU加速型I代 - g2：GPU加速型II代 - f1：FPGA高性能型 - f2：FPGA通用型 - c3：通用计算增强型 - e3：大内存型 - i3：超高I/O型
        /// </summary>
        [JsonProperty("ecs:generation", NullValueHandling = NullValueHandling.Ignore)]
        public string Ecsgeneration { get; set; }

        /// <summary>
        /// 虚拟化类型。  - 如果值为“FusionCompute”，表示弹性云服务器使用基于XEN的虚拟化技术。 - 如果值为“CloudCompute”，表示弹性云服务器使用基于KVM的虚拟化技术。
        /// </summary>
        [JsonProperty("ecs:virtualization_env_types", NullValueHandling = NullValueHandling.Ignore)]
        public string EcsvirtualizationEnvTypes { get; set; }

        /// <summary>
        /// 显卡是否直通。  值为“true”，表示GPU直通。
        /// </summary>
        [JsonProperty("pci_passthrough:enable_gpu", NullValueHandling = NullValueHandling.Ignore)]
        public string PciPassthroughenableGpu { get; set; }

        /// <summary>
        /// G1型和G2型云服务器应用的技术，包括GPU虚拟化和GPU直通。  - 如果该规格的云服务器使用GPU虚拟化技术，且GPU卡的型号为M60-1Q，参数值可设置为“m60_1q:virt:1”。 - 如果该规格的云服务器使用GPU直通技术，且GPU卡的型号为M60，参数值可设置为“m60:direct_graphics:1”。
        /// </summary>
        [JsonProperty("pci_passthrough:gpu_specs", NullValueHandling = NullValueHandling.Ignore)]
        public string PciPassthroughgpuSpecs { get; set; }

        /// <summary>
        /// P1型v本地直通GPU的型号和数量，参数值可设置为“nvidia-p100:1”，表示使用该规格创建的弹性云服务器将占用1张NVIDIA P100显卡。
        /// </summary>
        [JsonProperty("pci_passthrough:alias", NullValueHandling = NullValueHandling.Ignore)]
        public string PciPassthroughalias { get; set; }

        /// <summary>
        /// 此参数是Region级配置，某个AZ没有在cond:operation:az参数中配置时默认使用此参数的取值。不配置或无此参数时等同于“normal”。取值范围：  - normal：正常商用 - abandon：下线（即不显示） - sellout：售罄 - obt：公测 - promotion：推荐(等同normal，也是商用)
        /// </summary>
        [JsonProperty("cond:operation:status", NullValueHandling = NullValueHandling.Ignore)]
        public string Condoperationstatus { get; set; }

        /// <summary>
        /// 此参数是AZ级配置，某个AZ没有在此参数中配置时默认使用cond:operation:status参数的取值。此参数的配置格式“az(xx)”。()内为某个AZ的flavor状态，()内必须要填有状态，不填为无效配置。状态的取值范围与cond:operation:status参数相同。  例如：flavor在某个region的az0正常商用，az1售罄，az2公测，az3正常商用，其他az显示下线，可配置为：  - “cond:operation:status”设置为“abandon” - “cond:operation:az”设置为“az0(normal), az1(sellout), az2(obt), az3(normal)”  &gt; 说明：  - 如果flavor在某个AZ下的状态与cond:operation:status配置状态不同，必须配置该参数。
        /// </summary>
        [JsonProperty("cond:operation:az", NullValueHandling = NullValueHandling.Ignore)]
        public string Condoperationaz { get; set; }

        /// <summary>
        /// 最大带宽  - 单位Mbps，显示为Gbps时除以1000
        /// </summary>
        [JsonProperty("quota:max_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string QuotamaxRate { get; set; }

        /// <summary>
        /// 基准带宽  - 单位Mbps，显示为Gbps时除以1000
        /// </summary>
        [JsonProperty("quota:min_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string QuotaminRate { get; set; }

        /// <summary>
        /// 内网最大收发包能力  - 单位个，显示为xx万时除以10000
        /// </summary>
        [JsonProperty("quota:max_pps", NullValueHandling = NullValueHandling.Ignore)]
        public string QuotamaxPps { get; set; }

        /// <summary>
        /// 计费类型  - 计费场景，不配置时都支持 - period，包周期 - demand，按需
        /// </summary>
        [JsonProperty("cond:operation:charge", NullValueHandling = NullValueHandling.Ignore)]
        public string Condoperationcharge { get; set; }

        /// <summary>
        /// 关机是否收费  - 关机是否计费，默认免费： - charge - free
        /// </summary>
        [JsonProperty("cond:operation:charge:stop", NullValueHandling = NullValueHandling.Ignore)]
        public string Condoperationchargestop { get; set; }

        /// <summary>
        /// 计费类型  - 计费场景，不配置时都支持 - period，包周期 - demand，按需
        /// </summary>
        [JsonProperty("cond:spot:operation:az", NullValueHandling = NullValueHandling.Ignore)]
        public string Condspotoperationaz { get; set; }

        /// <summary>
        /// 允许的角色 匹配的用户标签（roles的op_gatexxx标签）。不设置时所有用户可见
        /// </summary>
        [JsonProperty("cond:operation:roles", NullValueHandling = NullValueHandling.Ignore)]
        public string Condoperationroles { get; set; }

        /// <summary>
        /// Flavor在竞价销售模式下的状态  - 不配置时等同abandon - normal，正常商用 - abandon，下线 - sellout，售罄 - obt，公测，未申请时提示申请（暂不支持） - private，私有，只给特定用户显示（暂不支持） - test，试用/免费（暂不支持） - promotion，推荐
        /// </summary>
        [JsonProperty("cond:spot:operation:status", NullValueHandling = NullValueHandling.Ignore)]
        public string Condspotoperationstatus { get; set; }

        /// <summary>
        /// 网络约束 支持网络特性，不配置时以UI配置为准。
        /// </summary>
        [JsonProperty("cond:network", NullValueHandling = NullValueHandling.Ignore)]
        public string Condnetwork { get; set; }

        /// <summary>
        /// 存储约束  - 支持磁盘特性，不配置时以UI配置为准。 - scsi，支持scsi - localdisk，支持本地盘 - ib，支持ib
        /// </summary>
        [JsonProperty("cond:storage", NullValueHandling = NullValueHandling.Ignore)]
        public string Condstorage { get; set; }

        /// <summary>
        /// 存储约束  - 支持磁盘特性，不配置时以UI配置为准。
        /// </summary>
        [JsonProperty("cond:storage:type", NullValueHandling = NullValueHandling.Ignore)]
        public string Condstoragetype { get; set; }

        /// <summary>
        /// 计算约束  - true，支持在线扩容。 - false或不存在该字段，不支持在线扩容。
        /// </summary>
        [JsonProperty("cond:compute:live_resizable", NullValueHandling = NullValueHandling.Ignore)]
        public string CondcomputeliveResizable { get; set; }

        /// <summary>
        /// 计算约束  - autorecovery，自动恢复特性。 - 不存在该字段，不支持自动恢复。
        /// </summary>
        [JsonProperty("cond:compute", NullValueHandling = NullValueHandling.Ignore)]
        public string Condcompute { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("info:gpu:name", NullValueHandling = NullValueHandling.Ignore)]
        public string Infogpuname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("info:cpu:name", NullValueHandling = NullValueHandling.Ignore)]
        public string Infocpuname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("quota:gpu", NullValueHandling = NullValueHandling.Ignore)]
        public string Quotagpu { get; set; }

        /// <summary>
        /// 最多支持的弹性网卡个数
        /// </summary>
        [JsonProperty("quota:vif_max_num", NullValueHandling = NullValueHandling.Ignore)]
        public string QuotavifMaxNum { get; set; }

        /// <summary>
        /// 最多支持的辅助弹性网卡个数
        /// </summary>
        [JsonProperty("quota:sub_network_interface_max_num", NullValueHandling = NullValueHandling.Ignore)]
        public string QuotasubNetworkInterfaceMaxNum { get; set; }

        /// <summary>
        /// 该规格对应的CPU架构，且仅鲲鹏实例架构规格返回该字段  - 取值为arm64表示CPU架构为鲲鹏计算。
        /// </summary>
        [JsonProperty("ecs:instance_architecture", NullValueHandling = NullValueHandling.Ignore)]
        public string EcsinstanceArchitecture { get; set; }

        /// <summary>
        /// 该规格是否支持流量镜像。
        /// </summary>
        [JsonProperty("network_interface:traffic_mirroring_supported", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkInterfacetrafficMirroringSupported { get; set; }

        /// <summary>
        /// 该规格是否支持QingTian Enclave。
        /// </summary>
        [JsonProperty("security:enclave_supported", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityenclaveSupported { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlavorExtraSpec {\n");
            sb.Append("  ecsperformancetype: ").Append(Ecsperformancetype).Append("\n");
            sb.Append("  hwnumaNodes: ").Append(HwnumaNodes).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  hpetSupport: ").Append(HpetSupport).Append("\n");
            sb.Append("  instanceVnictype: ").Append(InstanceVnictype).Append("\n");
            sb.Append("  instanceVnicinstanceBandwidth: ").Append(InstanceVnicinstanceBandwidth).Append("\n");
            sb.Append("  instanceVnicmaxCount: ").Append(InstanceVnicmaxCount).Append("\n");
            sb.Append("  quotalocalDisk: ").Append(QuotalocalDisk).Append("\n");
            sb.Append("  quotanvmeSsd: ").Append(QuotanvmeSsd).Append("\n");
            sb.Append("  extraSpeciopersistentGrant: ").Append(ExtraSpeciopersistentGrant).Append("\n");
            sb.Append("  ecsgeneration: ").Append(Ecsgeneration).Append("\n");
            sb.Append("  ecsvirtualizationEnvTypes: ").Append(EcsvirtualizationEnvTypes).Append("\n");
            sb.Append("  pciPassthroughenableGpu: ").Append(PciPassthroughenableGpu).Append("\n");
            sb.Append("  pciPassthroughgpuSpecs: ").Append(PciPassthroughgpuSpecs).Append("\n");
            sb.Append("  pciPassthroughalias: ").Append(PciPassthroughalias).Append("\n");
            sb.Append("  condoperationstatus: ").Append(Condoperationstatus).Append("\n");
            sb.Append("  condoperationaz: ").Append(Condoperationaz).Append("\n");
            sb.Append("  quotamaxRate: ").Append(QuotamaxRate).Append("\n");
            sb.Append("  quotaminRate: ").Append(QuotaminRate).Append("\n");
            sb.Append("  quotamaxPps: ").Append(QuotamaxPps).Append("\n");
            sb.Append("  condoperationcharge: ").Append(Condoperationcharge).Append("\n");
            sb.Append("  condoperationchargestop: ").Append(Condoperationchargestop).Append("\n");
            sb.Append("  condspotoperationaz: ").Append(Condspotoperationaz).Append("\n");
            sb.Append("  condoperationroles: ").Append(Condoperationroles).Append("\n");
            sb.Append("  condspotoperationstatus: ").Append(Condspotoperationstatus).Append("\n");
            sb.Append("  condnetwork: ").Append(Condnetwork).Append("\n");
            sb.Append("  condstorage: ").Append(Condstorage).Append("\n");
            sb.Append("  condstoragetype: ").Append(Condstoragetype).Append("\n");
            sb.Append("  condcomputeliveResizable: ").Append(CondcomputeliveResizable).Append("\n");
            sb.Append("  condcompute: ").Append(Condcompute).Append("\n");
            sb.Append("  infogpuname: ").Append(Infogpuname).Append("\n");
            sb.Append("  infocpuname: ").Append(Infocpuname).Append("\n");
            sb.Append("  quotagpu: ").Append(Quotagpu).Append("\n");
            sb.Append("  quotavifMaxNum: ").Append(QuotavifMaxNum).Append("\n");
            sb.Append("  quotasubNetworkInterfaceMaxNum: ").Append(QuotasubNetworkInterfaceMaxNum).Append("\n");
            sb.Append("  ecsinstanceArchitecture: ").Append(EcsinstanceArchitecture).Append("\n");
            sb.Append("  networkInterfacetrafficMirroringSupported: ").Append(NetworkInterfacetrafficMirroringSupported).Append("\n");
            sb.Append("  securityenclaveSupported: ").Append(SecurityenclaveSupported).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlavorExtraSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlavorExtraSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ecsperformancetype == input.Ecsperformancetype ||
                    (this.Ecsperformancetype != null &&
                    this.Ecsperformancetype.Equals(input.Ecsperformancetype))
                ) && 
                (
                    this.HwnumaNodes == input.HwnumaNodes ||
                    (this.HwnumaNodes != null &&
                    this.HwnumaNodes.Equals(input.HwnumaNodes))
                ) && 
                (
                    this.ResourceType == input.ResourceType ||
                    (this.ResourceType != null &&
                    this.ResourceType.Equals(input.ResourceType))
                ) && 
                (
                    this.HpetSupport == input.HpetSupport ||
                    (this.HpetSupport != null &&
                    this.HpetSupport.Equals(input.HpetSupport))
                ) && 
                (
                    this.InstanceVnictype == input.InstanceVnictype ||
                    (this.InstanceVnictype != null &&
                    this.InstanceVnictype.Equals(input.InstanceVnictype))
                ) && 
                (
                    this.InstanceVnicinstanceBandwidth == input.InstanceVnicinstanceBandwidth ||
                    (this.InstanceVnicinstanceBandwidth != null &&
                    this.InstanceVnicinstanceBandwidth.Equals(input.InstanceVnicinstanceBandwidth))
                ) && 
                (
                    this.InstanceVnicmaxCount == input.InstanceVnicmaxCount ||
                    (this.InstanceVnicmaxCount != null &&
                    this.InstanceVnicmaxCount.Equals(input.InstanceVnicmaxCount))
                ) && 
                (
                    this.QuotalocalDisk == input.QuotalocalDisk ||
                    (this.QuotalocalDisk != null &&
                    this.QuotalocalDisk.Equals(input.QuotalocalDisk))
                ) && 
                (
                    this.QuotanvmeSsd == input.QuotanvmeSsd ||
                    (this.QuotanvmeSsd != null &&
                    this.QuotanvmeSsd.Equals(input.QuotanvmeSsd))
                ) && 
                (
                    this.ExtraSpeciopersistentGrant == input.ExtraSpeciopersistentGrant ||
                    (this.ExtraSpeciopersistentGrant != null &&
                    this.ExtraSpeciopersistentGrant.Equals(input.ExtraSpeciopersistentGrant))
                ) && 
                (
                    this.Ecsgeneration == input.Ecsgeneration ||
                    (this.Ecsgeneration != null &&
                    this.Ecsgeneration.Equals(input.Ecsgeneration))
                ) && 
                (
                    this.EcsvirtualizationEnvTypes == input.EcsvirtualizationEnvTypes ||
                    (this.EcsvirtualizationEnvTypes != null &&
                    this.EcsvirtualizationEnvTypes.Equals(input.EcsvirtualizationEnvTypes))
                ) && 
                (
                    this.PciPassthroughenableGpu == input.PciPassthroughenableGpu ||
                    (this.PciPassthroughenableGpu != null &&
                    this.PciPassthroughenableGpu.Equals(input.PciPassthroughenableGpu))
                ) && 
                (
                    this.PciPassthroughgpuSpecs == input.PciPassthroughgpuSpecs ||
                    (this.PciPassthroughgpuSpecs != null &&
                    this.PciPassthroughgpuSpecs.Equals(input.PciPassthroughgpuSpecs))
                ) && 
                (
                    this.PciPassthroughalias == input.PciPassthroughalias ||
                    (this.PciPassthroughalias != null &&
                    this.PciPassthroughalias.Equals(input.PciPassthroughalias))
                ) && 
                (
                    this.Condoperationstatus == input.Condoperationstatus ||
                    (this.Condoperationstatus != null &&
                    this.Condoperationstatus.Equals(input.Condoperationstatus))
                ) && 
                (
                    this.Condoperationaz == input.Condoperationaz ||
                    (this.Condoperationaz != null &&
                    this.Condoperationaz.Equals(input.Condoperationaz))
                ) && 
                (
                    this.QuotamaxRate == input.QuotamaxRate ||
                    (this.QuotamaxRate != null &&
                    this.QuotamaxRate.Equals(input.QuotamaxRate))
                ) && 
                (
                    this.QuotaminRate == input.QuotaminRate ||
                    (this.QuotaminRate != null &&
                    this.QuotaminRate.Equals(input.QuotaminRate))
                ) && 
                (
                    this.QuotamaxPps == input.QuotamaxPps ||
                    (this.QuotamaxPps != null &&
                    this.QuotamaxPps.Equals(input.QuotamaxPps))
                ) && 
                (
                    this.Condoperationcharge == input.Condoperationcharge ||
                    (this.Condoperationcharge != null &&
                    this.Condoperationcharge.Equals(input.Condoperationcharge))
                ) && 
                (
                    this.Condoperationchargestop == input.Condoperationchargestop ||
                    (this.Condoperationchargestop != null &&
                    this.Condoperationchargestop.Equals(input.Condoperationchargestop))
                ) && 
                (
                    this.Condspotoperationaz == input.Condspotoperationaz ||
                    (this.Condspotoperationaz != null &&
                    this.Condspotoperationaz.Equals(input.Condspotoperationaz))
                ) && 
                (
                    this.Condoperationroles == input.Condoperationroles ||
                    (this.Condoperationroles != null &&
                    this.Condoperationroles.Equals(input.Condoperationroles))
                ) && 
                (
                    this.Condspotoperationstatus == input.Condspotoperationstatus ||
                    (this.Condspotoperationstatus != null &&
                    this.Condspotoperationstatus.Equals(input.Condspotoperationstatus))
                ) && 
                (
                    this.Condnetwork == input.Condnetwork ||
                    (this.Condnetwork != null &&
                    this.Condnetwork.Equals(input.Condnetwork))
                ) && 
                (
                    this.Condstorage == input.Condstorage ||
                    (this.Condstorage != null &&
                    this.Condstorage.Equals(input.Condstorage))
                ) && 
                (
                    this.Condstoragetype == input.Condstoragetype ||
                    (this.Condstoragetype != null &&
                    this.Condstoragetype.Equals(input.Condstoragetype))
                ) && 
                (
                    this.CondcomputeliveResizable == input.CondcomputeliveResizable ||
                    (this.CondcomputeliveResizable != null &&
                    this.CondcomputeliveResizable.Equals(input.CondcomputeliveResizable))
                ) && 
                (
                    this.Condcompute == input.Condcompute ||
                    (this.Condcompute != null &&
                    this.Condcompute.Equals(input.Condcompute))
                ) && 
                (
                    this.Infogpuname == input.Infogpuname ||
                    (this.Infogpuname != null &&
                    this.Infogpuname.Equals(input.Infogpuname))
                ) && 
                (
                    this.Infocpuname == input.Infocpuname ||
                    (this.Infocpuname != null &&
                    this.Infocpuname.Equals(input.Infocpuname))
                ) && 
                (
                    this.Quotagpu == input.Quotagpu ||
                    (this.Quotagpu != null &&
                    this.Quotagpu.Equals(input.Quotagpu))
                ) && 
                (
                    this.QuotavifMaxNum == input.QuotavifMaxNum ||
                    (this.QuotavifMaxNum != null &&
                    this.QuotavifMaxNum.Equals(input.QuotavifMaxNum))
                ) && 
                (
                    this.QuotasubNetworkInterfaceMaxNum == input.QuotasubNetworkInterfaceMaxNum ||
                    (this.QuotasubNetworkInterfaceMaxNum != null &&
                    this.QuotasubNetworkInterfaceMaxNum.Equals(input.QuotasubNetworkInterfaceMaxNum))
                ) && 
                (
                    this.EcsinstanceArchitecture == input.EcsinstanceArchitecture ||
                    (this.EcsinstanceArchitecture != null &&
                    this.EcsinstanceArchitecture.Equals(input.EcsinstanceArchitecture))
                ) && 
                (
                    this.NetworkInterfacetrafficMirroringSupported == input.NetworkInterfacetrafficMirroringSupported ||
                    (this.NetworkInterfacetrafficMirroringSupported != null &&
                    this.NetworkInterfacetrafficMirroringSupported.Equals(input.NetworkInterfacetrafficMirroringSupported))
                ) && 
                (
                    this.SecurityenclaveSupported == input.SecurityenclaveSupported ||
                    (this.SecurityenclaveSupported != null &&
                    this.SecurityenclaveSupported.Equals(input.SecurityenclaveSupported))
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
                if (this.Ecsperformancetype != null)
                    hashCode = hashCode * 59 + this.Ecsperformancetype.GetHashCode();
                if (this.HwnumaNodes != null)
                    hashCode = hashCode * 59 + this.HwnumaNodes.GetHashCode();
                if (this.ResourceType != null)
                    hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.HpetSupport != null)
                    hashCode = hashCode * 59 + this.HpetSupport.GetHashCode();
                if (this.InstanceVnictype != null)
                    hashCode = hashCode * 59 + this.InstanceVnictype.GetHashCode();
                if (this.InstanceVnicinstanceBandwidth != null)
                    hashCode = hashCode * 59 + this.InstanceVnicinstanceBandwidth.GetHashCode();
                if (this.InstanceVnicmaxCount != null)
                    hashCode = hashCode * 59 + this.InstanceVnicmaxCount.GetHashCode();
                if (this.QuotalocalDisk != null)
                    hashCode = hashCode * 59 + this.QuotalocalDisk.GetHashCode();
                if (this.QuotanvmeSsd != null)
                    hashCode = hashCode * 59 + this.QuotanvmeSsd.GetHashCode();
                if (this.ExtraSpeciopersistentGrant != null)
                    hashCode = hashCode * 59 + this.ExtraSpeciopersistentGrant.GetHashCode();
                if (this.Ecsgeneration != null)
                    hashCode = hashCode * 59 + this.Ecsgeneration.GetHashCode();
                if (this.EcsvirtualizationEnvTypes != null)
                    hashCode = hashCode * 59 + this.EcsvirtualizationEnvTypes.GetHashCode();
                if (this.PciPassthroughenableGpu != null)
                    hashCode = hashCode * 59 + this.PciPassthroughenableGpu.GetHashCode();
                if (this.PciPassthroughgpuSpecs != null)
                    hashCode = hashCode * 59 + this.PciPassthroughgpuSpecs.GetHashCode();
                if (this.PciPassthroughalias != null)
                    hashCode = hashCode * 59 + this.PciPassthroughalias.GetHashCode();
                if (this.Condoperationstatus != null)
                    hashCode = hashCode * 59 + this.Condoperationstatus.GetHashCode();
                if (this.Condoperationaz != null)
                    hashCode = hashCode * 59 + this.Condoperationaz.GetHashCode();
                if (this.QuotamaxRate != null)
                    hashCode = hashCode * 59 + this.QuotamaxRate.GetHashCode();
                if (this.QuotaminRate != null)
                    hashCode = hashCode * 59 + this.QuotaminRate.GetHashCode();
                if (this.QuotamaxPps != null)
                    hashCode = hashCode * 59 + this.QuotamaxPps.GetHashCode();
                if (this.Condoperationcharge != null)
                    hashCode = hashCode * 59 + this.Condoperationcharge.GetHashCode();
                if (this.Condoperationchargestop != null)
                    hashCode = hashCode * 59 + this.Condoperationchargestop.GetHashCode();
                if (this.Condspotoperationaz != null)
                    hashCode = hashCode * 59 + this.Condspotoperationaz.GetHashCode();
                if (this.Condoperationroles != null)
                    hashCode = hashCode * 59 + this.Condoperationroles.GetHashCode();
                if (this.Condspotoperationstatus != null)
                    hashCode = hashCode * 59 + this.Condspotoperationstatus.GetHashCode();
                if (this.Condnetwork != null)
                    hashCode = hashCode * 59 + this.Condnetwork.GetHashCode();
                if (this.Condstorage != null)
                    hashCode = hashCode * 59 + this.Condstorage.GetHashCode();
                if (this.Condstoragetype != null)
                    hashCode = hashCode * 59 + this.Condstoragetype.GetHashCode();
                if (this.CondcomputeliveResizable != null)
                    hashCode = hashCode * 59 + this.CondcomputeliveResizable.GetHashCode();
                if (this.Condcompute != null)
                    hashCode = hashCode * 59 + this.Condcompute.GetHashCode();
                if (this.Infogpuname != null)
                    hashCode = hashCode * 59 + this.Infogpuname.GetHashCode();
                if (this.Infocpuname != null)
                    hashCode = hashCode * 59 + this.Infocpuname.GetHashCode();
                if (this.Quotagpu != null)
                    hashCode = hashCode * 59 + this.Quotagpu.GetHashCode();
                if (this.QuotavifMaxNum != null)
                    hashCode = hashCode * 59 + this.QuotavifMaxNum.GetHashCode();
                if (this.QuotasubNetworkInterfaceMaxNum != null)
                    hashCode = hashCode * 59 + this.QuotasubNetworkInterfaceMaxNum.GetHashCode();
                if (this.EcsinstanceArchitecture != null)
                    hashCode = hashCode * 59 + this.EcsinstanceArchitecture.GetHashCode();
                if (this.NetworkInterfacetrafficMirroringSupported != null)
                    hashCode = hashCode * 59 + this.NetworkInterfacetrafficMirroringSupported.GetHashCode();
                if (this.SecurityenclaveSupported != null)
                    hashCode = hashCode * 59 + this.SecurityenclaveSupported.GetHashCode();
                return hashCode;
            }
        }
    }
}
