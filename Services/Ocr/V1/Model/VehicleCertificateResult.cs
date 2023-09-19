using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ocr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VehicleCertificateResult 
    {

        /// <summary>
        /// 合格证编号。 
        /// </summary>
        [JsonProperty("certificate_number", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateNumber { get; set; }

        /// <summary>
        /// 发证日期。 
        /// </summary>
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueDate { get; set; }

        /// <summary>
        /// 车辆制造企业名称。 
        /// </summary>
        [JsonProperty("manufacture_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ManufactureName { get; set; }

        /// <summary>
        /// 车辆品牌。 
        /// </summary>
        [JsonProperty("vehicle_brand", NullValueHandling = NullValueHandling.Ignore)]
        public string VehicleBrand { get; set; }

        /// <summary>
        /// 车辆名称。 
        /// </summary>
        [JsonProperty("vehicle_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VehicleName { get; set; }

        /// <summary>
        /// 车辆型号。 
        /// </summary>
        [JsonProperty("vehicle_model", NullValueHandling = NullValueHandling.Ignore)]
        public string VehicleModel { get; set; }

        /// <summary>
        /// 车架号。 
        /// </summary>
        [JsonProperty("vin", NullValueHandling = NullValueHandling.Ignore)]
        public string Vin { get; set; }

        /// <summary>
        /// 车身颜色。 
        /// </summary>
        [JsonProperty("vehicle_color", NullValueHandling = NullValueHandling.Ignore)]
        public string VehicleColor { get; set; }

        /// <summary>
        /// 底盘型号。 
        /// </summary>
        [JsonProperty("chassis_model", NullValueHandling = NullValueHandling.Ignore)]
        public string ChassisModel { get; set; }

        /// <summary>
        /// 底盘ID。 
        /// </summary>
        [JsonProperty("chassis_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ChassisId { get; set; }

        /// <summary>
        /// 底盘合格证编号。 
        /// </summary>
        [JsonProperty("chassis_certificate_number", NullValueHandling = NullValueHandling.Ignore)]
        public string ChassisCertificateNumber { get; set; }

        /// <summary>
        /// 发动机型号。 
        /// </summary>
        [JsonProperty("engine_model", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineModel { get; set; }

        /// <summary>
        /// 发动机号。 
        /// </summary>
        [JsonProperty("engine_number", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineNumber { get; set; }

        /// <summary>
        /// 燃料种类。 
        /// </summary>
        [JsonProperty("fuel_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FuelType { get; set; }

        /// <summary>
        /// 排量。 
        /// </summary>
        [JsonProperty("displacement", NullValueHandling = NullValueHandling.Ignore)]
        public string Displacement { get; set; }

        /// <summary>
        /// 功率。 
        /// </summary>
        [JsonProperty("power", NullValueHandling = NullValueHandling.Ignore)]
        public string Power { get; set; }

        /// <summary>
        /// 排放标准。 
        /// </summary>
        [JsonProperty("emission_standard", NullValueHandling = NullValueHandling.Ignore)]
        public string EmissionStandard { get; set; }

        /// <summary>
        /// 油耗。 
        /// </summary>
        [JsonProperty("fuel_consumption", NullValueHandling = NullValueHandling.Ignore)]
        public string FuelConsumption { get; set; }

        /// <summary>
        /// 外廓尺寸-长。 
        /// </summary>
        [JsonProperty("overall_dimension_length", NullValueHandling = NullValueHandling.Ignore)]
        public string OverallDimensionLength { get; set; }

        /// <summary>
        /// 外廓尺寸-宽。 
        /// </summary>
        [JsonProperty("overall_dimension_width", NullValueHandling = NullValueHandling.Ignore)]
        public string OverallDimensionWidth { get; set; }

        /// <summary>
        /// 外廓尺寸-高。 
        /// </summary>
        [JsonProperty("overall_dimension_height", NullValueHandling = NullValueHandling.Ignore)]
        public string OverallDimensionHeight { get; set; }

        /// <summary>
        /// 货厢内部尺寸-长。 
        /// </summary>
        [JsonProperty("container_dimension_length", NullValueHandling = NullValueHandling.Ignore)]
        public string ContainerDimensionLength { get; set; }

        /// <summary>
        /// 货厢内部尺寸-宽。 
        /// </summary>
        [JsonProperty("container_dimension_width", NullValueHandling = NullValueHandling.Ignore)]
        public string ContainerDimensionWidth { get; set; }

        /// <summary>
        /// 货厢内部尺寸-高。 
        /// </summary>
        [JsonProperty("container_dimension_height", NullValueHandling = NullValueHandling.Ignore)]
        public string ContainerDimensionHeight { get; set; }

        /// <summary>
        /// 钢板弹簧片数。 
        /// </summary>
        [JsonProperty("spring_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public string SpringQuantity { get; set; }

        /// <summary>
        /// 轮胎数。 
        /// </summary>
        [JsonProperty("tire_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public string TireQuantity { get; set; }

        /// <summary>
        /// 轮胎规格。 
        /// </summary>
        [JsonProperty("tire_size", NullValueHandling = NullValueHandling.Ignore)]
        public string TireSize { get; set; }

        /// <summary>
        /// 轮距-前。 
        /// </summary>
        [JsonProperty("front_wheel_track", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontWheelTrack { get; set; }

        /// <summary>
        /// 轮距-后。 
        /// </summary>
        [JsonProperty("rear_wheel_track", NullValueHandling = NullValueHandling.Ignore)]
        public string RearWheelTrack { get; set; }

        /// <summary>
        /// 轴距。 
        /// </summary>
        [JsonProperty("wheelbase", NullValueHandling = NullValueHandling.Ignore)]
        public string Wheelbase { get; set; }

        /// <summary>
        /// 轴荷。 
        /// </summary>
        [JsonProperty("axle_load", NullValueHandling = NullValueHandling.Ignore)]
        public string AxleLoad { get; set; }

        /// <summary>
        /// 轴数。 
        /// </summary>
        [JsonProperty("axle_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public string AxleQuantity { get; set; }

        /// <summary>
        /// 转向形式。 
        /// </summary>
        [JsonProperty("steering_form", NullValueHandling = NullValueHandling.Ignore)]
        public string SteeringForm { get; set; }

        /// <summary>
        /// 总质量。 
        /// </summary>
        [JsonProperty("total_weight", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalWeight { get; set; }

        /// <summary>
        /// 整备质量。 
        /// </summary>
        [JsonProperty("equipment_weight", NullValueHandling = NullValueHandling.Ignore)]
        public string EquipmentWeight { get; set; }

        /// <summary>
        /// 额定载质量。 
        /// </summary>
        [JsonProperty("maximum_laden_mass", NullValueHandling = NullValueHandling.Ignore)]
        public string MaximumLadenMass { get; set; }

        /// <summary>
        /// 载质量利用系数。 
        /// </summary>
        [JsonProperty("mass_utilization_coefficient", NullValueHandling = NullValueHandling.Ignore)]
        public string MassUtilizationCoefficient { get; set; }

        /// <summary>
        /// 准牵引总质量。 
        /// </summary>
        [JsonProperty("traction_weight", NullValueHandling = NullValueHandling.Ignore)]
        public string TractionWeight { get; set; }

        /// <summary>
        /// 半挂车鞍座最大允许总质量。 
        /// </summary>
        [JsonProperty("maximum_load_mass", NullValueHandling = NullValueHandling.Ignore)]
        public string MaximumLoadMass { get; set; }

        /// <summary>
        /// 驾驶室准乘人数。 
        /// </summary>
        [JsonProperty("cab_passenger_capacity", NullValueHandling = NullValueHandling.Ignore)]
        public string CabPassengerCapacity { get; set; }

        /// <summary>
        /// 额定载客。 
        /// </summary>
        [JsonProperty("passenger_capacity", NullValueHandling = NullValueHandling.Ignore)]
        public string PassengerCapacity { get; set; }

        /// <summary>
        /// 最高设计车速。 
        /// </summary>
        [JsonProperty("max_design_speed", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxDesignSpeed { get; set; }

        /// <summary>
        /// 车辆制造日期。 
        /// </summary>
        [JsonProperty("manufacture_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ManufactureDate { get; set; }

        /// <summary>
        /// 字段的置信度，取值范围0~1。 置信度越大，本次识别的字段的可靠性越高，在统计意义上，置信度越大，准确率越高。 置信度由算法给出，不直接等价于字段的准确率。 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public Object Confidence { get; set; }

        /// <summary>
        /// 对应所有在原图上识别到的字段位置信息，包含所有文字区域四个顶点的二维坐标（x,y）。采用图像坐标系，坐标原点为图片左上角，x轴沿水平方向，y轴沿竖直方向。 
        /// </summary>
        [JsonProperty("text_location", NullValueHandling = NullValueHandling.Ignore)]
        public Object TextLocation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VehicleCertificateResult {\n");
            sb.Append("  certificateNumber: ").Append(CertificateNumber).Append("\n");
            sb.Append("  issueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  manufactureName: ").Append(ManufactureName).Append("\n");
            sb.Append("  vehicleBrand: ").Append(VehicleBrand).Append("\n");
            sb.Append("  vehicleName: ").Append(VehicleName).Append("\n");
            sb.Append("  vehicleModel: ").Append(VehicleModel).Append("\n");
            sb.Append("  vin: ").Append(Vin).Append("\n");
            sb.Append("  vehicleColor: ").Append(VehicleColor).Append("\n");
            sb.Append("  chassisModel: ").Append(ChassisModel).Append("\n");
            sb.Append("  chassisId: ").Append(ChassisId).Append("\n");
            sb.Append("  chassisCertificateNumber: ").Append(ChassisCertificateNumber).Append("\n");
            sb.Append("  engineModel: ").Append(EngineModel).Append("\n");
            sb.Append("  engineNumber: ").Append(EngineNumber).Append("\n");
            sb.Append("  fuelType: ").Append(FuelType).Append("\n");
            sb.Append("  displacement: ").Append(Displacement).Append("\n");
            sb.Append("  power: ").Append(Power).Append("\n");
            sb.Append("  emissionStandard: ").Append(EmissionStandard).Append("\n");
            sb.Append("  fuelConsumption: ").Append(FuelConsumption).Append("\n");
            sb.Append("  overallDimensionLength: ").Append(OverallDimensionLength).Append("\n");
            sb.Append("  overallDimensionWidth: ").Append(OverallDimensionWidth).Append("\n");
            sb.Append("  overallDimensionHeight: ").Append(OverallDimensionHeight).Append("\n");
            sb.Append("  containerDimensionLength: ").Append(ContainerDimensionLength).Append("\n");
            sb.Append("  containerDimensionWidth: ").Append(ContainerDimensionWidth).Append("\n");
            sb.Append("  containerDimensionHeight: ").Append(ContainerDimensionHeight).Append("\n");
            sb.Append("  springQuantity: ").Append(SpringQuantity).Append("\n");
            sb.Append("  tireQuantity: ").Append(TireQuantity).Append("\n");
            sb.Append("  tireSize: ").Append(TireSize).Append("\n");
            sb.Append("  frontWheelTrack: ").Append(FrontWheelTrack).Append("\n");
            sb.Append("  rearWheelTrack: ").Append(RearWheelTrack).Append("\n");
            sb.Append("  wheelbase: ").Append(Wheelbase).Append("\n");
            sb.Append("  axleLoad: ").Append(AxleLoad).Append("\n");
            sb.Append("  axleQuantity: ").Append(AxleQuantity).Append("\n");
            sb.Append("  steeringForm: ").Append(SteeringForm).Append("\n");
            sb.Append("  totalWeight: ").Append(TotalWeight).Append("\n");
            sb.Append("  equipmentWeight: ").Append(EquipmentWeight).Append("\n");
            sb.Append("  maximumLadenMass: ").Append(MaximumLadenMass).Append("\n");
            sb.Append("  massUtilizationCoefficient: ").Append(MassUtilizationCoefficient).Append("\n");
            sb.Append("  tractionWeight: ").Append(TractionWeight).Append("\n");
            sb.Append("  maximumLoadMass: ").Append(MaximumLoadMass).Append("\n");
            sb.Append("  cabPassengerCapacity: ").Append(CabPassengerCapacity).Append("\n");
            sb.Append("  passengerCapacity: ").Append(PassengerCapacity).Append("\n");
            sb.Append("  maxDesignSpeed: ").Append(MaxDesignSpeed).Append("\n");
            sb.Append("  manufactureDate: ").Append(ManufactureDate).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("  textLocation: ").Append(TextLocation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VehicleCertificateResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VehicleCertificateResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CertificateNumber == input.CertificateNumber ||
                    (this.CertificateNumber != null &&
                    this.CertificateNumber.Equals(input.CertificateNumber))
                ) && 
                (
                    this.IssueDate == input.IssueDate ||
                    (this.IssueDate != null &&
                    this.IssueDate.Equals(input.IssueDate))
                ) && 
                (
                    this.ManufactureName == input.ManufactureName ||
                    (this.ManufactureName != null &&
                    this.ManufactureName.Equals(input.ManufactureName))
                ) && 
                (
                    this.VehicleBrand == input.VehicleBrand ||
                    (this.VehicleBrand != null &&
                    this.VehicleBrand.Equals(input.VehicleBrand))
                ) && 
                (
                    this.VehicleName == input.VehicleName ||
                    (this.VehicleName != null &&
                    this.VehicleName.Equals(input.VehicleName))
                ) && 
                (
                    this.VehicleModel == input.VehicleModel ||
                    (this.VehicleModel != null &&
                    this.VehicleModel.Equals(input.VehicleModel))
                ) && 
                (
                    this.Vin == input.Vin ||
                    (this.Vin != null &&
                    this.Vin.Equals(input.Vin))
                ) && 
                (
                    this.VehicleColor == input.VehicleColor ||
                    (this.VehicleColor != null &&
                    this.VehicleColor.Equals(input.VehicleColor))
                ) && 
                (
                    this.ChassisModel == input.ChassisModel ||
                    (this.ChassisModel != null &&
                    this.ChassisModel.Equals(input.ChassisModel))
                ) && 
                (
                    this.ChassisId == input.ChassisId ||
                    (this.ChassisId != null &&
                    this.ChassisId.Equals(input.ChassisId))
                ) && 
                (
                    this.ChassisCertificateNumber == input.ChassisCertificateNumber ||
                    (this.ChassisCertificateNumber != null &&
                    this.ChassisCertificateNumber.Equals(input.ChassisCertificateNumber))
                ) && 
                (
                    this.EngineModel == input.EngineModel ||
                    (this.EngineModel != null &&
                    this.EngineModel.Equals(input.EngineModel))
                ) && 
                (
                    this.EngineNumber == input.EngineNumber ||
                    (this.EngineNumber != null &&
                    this.EngineNumber.Equals(input.EngineNumber))
                ) && 
                (
                    this.FuelType == input.FuelType ||
                    (this.FuelType != null &&
                    this.FuelType.Equals(input.FuelType))
                ) && 
                (
                    this.Displacement == input.Displacement ||
                    (this.Displacement != null &&
                    this.Displacement.Equals(input.Displacement))
                ) && 
                (
                    this.Power == input.Power ||
                    (this.Power != null &&
                    this.Power.Equals(input.Power))
                ) && 
                (
                    this.EmissionStandard == input.EmissionStandard ||
                    (this.EmissionStandard != null &&
                    this.EmissionStandard.Equals(input.EmissionStandard))
                ) && 
                (
                    this.FuelConsumption == input.FuelConsumption ||
                    (this.FuelConsumption != null &&
                    this.FuelConsumption.Equals(input.FuelConsumption))
                ) && 
                (
                    this.OverallDimensionLength == input.OverallDimensionLength ||
                    (this.OverallDimensionLength != null &&
                    this.OverallDimensionLength.Equals(input.OverallDimensionLength))
                ) && 
                (
                    this.OverallDimensionWidth == input.OverallDimensionWidth ||
                    (this.OverallDimensionWidth != null &&
                    this.OverallDimensionWidth.Equals(input.OverallDimensionWidth))
                ) && 
                (
                    this.OverallDimensionHeight == input.OverallDimensionHeight ||
                    (this.OverallDimensionHeight != null &&
                    this.OverallDimensionHeight.Equals(input.OverallDimensionHeight))
                ) && 
                (
                    this.ContainerDimensionLength == input.ContainerDimensionLength ||
                    (this.ContainerDimensionLength != null &&
                    this.ContainerDimensionLength.Equals(input.ContainerDimensionLength))
                ) && 
                (
                    this.ContainerDimensionWidth == input.ContainerDimensionWidth ||
                    (this.ContainerDimensionWidth != null &&
                    this.ContainerDimensionWidth.Equals(input.ContainerDimensionWidth))
                ) && 
                (
                    this.ContainerDimensionHeight == input.ContainerDimensionHeight ||
                    (this.ContainerDimensionHeight != null &&
                    this.ContainerDimensionHeight.Equals(input.ContainerDimensionHeight))
                ) && 
                (
                    this.SpringQuantity == input.SpringQuantity ||
                    (this.SpringQuantity != null &&
                    this.SpringQuantity.Equals(input.SpringQuantity))
                ) && 
                (
                    this.TireQuantity == input.TireQuantity ||
                    (this.TireQuantity != null &&
                    this.TireQuantity.Equals(input.TireQuantity))
                ) && 
                (
                    this.TireSize == input.TireSize ||
                    (this.TireSize != null &&
                    this.TireSize.Equals(input.TireSize))
                ) && 
                (
                    this.FrontWheelTrack == input.FrontWheelTrack ||
                    (this.FrontWheelTrack != null &&
                    this.FrontWheelTrack.Equals(input.FrontWheelTrack))
                ) && 
                (
                    this.RearWheelTrack == input.RearWheelTrack ||
                    (this.RearWheelTrack != null &&
                    this.RearWheelTrack.Equals(input.RearWheelTrack))
                ) && 
                (
                    this.Wheelbase == input.Wheelbase ||
                    (this.Wheelbase != null &&
                    this.Wheelbase.Equals(input.Wheelbase))
                ) && 
                (
                    this.AxleLoad == input.AxleLoad ||
                    (this.AxleLoad != null &&
                    this.AxleLoad.Equals(input.AxleLoad))
                ) && 
                (
                    this.AxleQuantity == input.AxleQuantity ||
                    (this.AxleQuantity != null &&
                    this.AxleQuantity.Equals(input.AxleQuantity))
                ) && 
                (
                    this.SteeringForm == input.SteeringForm ||
                    (this.SteeringForm != null &&
                    this.SteeringForm.Equals(input.SteeringForm))
                ) && 
                (
                    this.TotalWeight == input.TotalWeight ||
                    (this.TotalWeight != null &&
                    this.TotalWeight.Equals(input.TotalWeight))
                ) && 
                (
                    this.EquipmentWeight == input.EquipmentWeight ||
                    (this.EquipmentWeight != null &&
                    this.EquipmentWeight.Equals(input.EquipmentWeight))
                ) && 
                (
                    this.MaximumLadenMass == input.MaximumLadenMass ||
                    (this.MaximumLadenMass != null &&
                    this.MaximumLadenMass.Equals(input.MaximumLadenMass))
                ) && 
                (
                    this.MassUtilizationCoefficient == input.MassUtilizationCoefficient ||
                    (this.MassUtilizationCoefficient != null &&
                    this.MassUtilizationCoefficient.Equals(input.MassUtilizationCoefficient))
                ) && 
                (
                    this.TractionWeight == input.TractionWeight ||
                    (this.TractionWeight != null &&
                    this.TractionWeight.Equals(input.TractionWeight))
                ) && 
                (
                    this.MaximumLoadMass == input.MaximumLoadMass ||
                    (this.MaximumLoadMass != null &&
                    this.MaximumLoadMass.Equals(input.MaximumLoadMass))
                ) && 
                (
                    this.CabPassengerCapacity == input.CabPassengerCapacity ||
                    (this.CabPassengerCapacity != null &&
                    this.CabPassengerCapacity.Equals(input.CabPassengerCapacity))
                ) && 
                (
                    this.PassengerCapacity == input.PassengerCapacity ||
                    (this.PassengerCapacity != null &&
                    this.PassengerCapacity.Equals(input.PassengerCapacity))
                ) && 
                (
                    this.MaxDesignSpeed == input.MaxDesignSpeed ||
                    (this.MaxDesignSpeed != null &&
                    this.MaxDesignSpeed.Equals(input.MaxDesignSpeed))
                ) && 
                (
                    this.ManufactureDate == input.ManufactureDate ||
                    (this.ManufactureDate != null &&
                    this.ManufactureDate.Equals(input.ManufactureDate))
                ) && 
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
                ) && 
                (
                    this.TextLocation == input.TextLocation ||
                    (this.TextLocation != null &&
                    this.TextLocation.Equals(input.TextLocation))
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
                if (this.CertificateNumber != null)
                    hashCode = hashCode * 59 + this.CertificateNumber.GetHashCode();
                if (this.IssueDate != null)
                    hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.ManufactureName != null)
                    hashCode = hashCode * 59 + this.ManufactureName.GetHashCode();
                if (this.VehicleBrand != null)
                    hashCode = hashCode * 59 + this.VehicleBrand.GetHashCode();
                if (this.VehicleName != null)
                    hashCode = hashCode * 59 + this.VehicleName.GetHashCode();
                if (this.VehicleModel != null)
                    hashCode = hashCode * 59 + this.VehicleModel.GetHashCode();
                if (this.Vin != null)
                    hashCode = hashCode * 59 + this.Vin.GetHashCode();
                if (this.VehicleColor != null)
                    hashCode = hashCode * 59 + this.VehicleColor.GetHashCode();
                if (this.ChassisModel != null)
                    hashCode = hashCode * 59 + this.ChassisModel.GetHashCode();
                if (this.ChassisId != null)
                    hashCode = hashCode * 59 + this.ChassisId.GetHashCode();
                if (this.ChassisCertificateNumber != null)
                    hashCode = hashCode * 59 + this.ChassisCertificateNumber.GetHashCode();
                if (this.EngineModel != null)
                    hashCode = hashCode * 59 + this.EngineModel.GetHashCode();
                if (this.EngineNumber != null)
                    hashCode = hashCode * 59 + this.EngineNumber.GetHashCode();
                if (this.FuelType != null)
                    hashCode = hashCode * 59 + this.FuelType.GetHashCode();
                if (this.Displacement != null)
                    hashCode = hashCode * 59 + this.Displacement.GetHashCode();
                if (this.Power != null)
                    hashCode = hashCode * 59 + this.Power.GetHashCode();
                if (this.EmissionStandard != null)
                    hashCode = hashCode * 59 + this.EmissionStandard.GetHashCode();
                if (this.FuelConsumption != null)
                    hashCode = hashCode * 59 + this.FuelConsumption.GetHashCode();
                if (this.OverallDimensionLength != null)
                    hashCode = hashCode * 59 + this.OverallDimensionLength.GetHashCode();
                if (this.OverallDimensionWidth != null)
                    hashCode = hashCode * 59 + this.OverallDimensionWidth.GetHashCode();
                if (this.OverallDimensionHeight != null)
                    hashCode = hashCode * 59 + this.OverallDimensionHeight.GetHashCode();
                if (this.ContainerDimensionLength != null)
                    hashCode = hashCode * 59 + this.ContainerDimensionLength.GetHashCode();
                if (this.ContainerDimensionWidth != null)
                    hashCode = hashCode * 59 + this.ContainerDimensionWidth.GetHashCode();
                if (this.ContainerDimensionHeight != null)
                    hashCode = hashCode * 59 + this.ContainerDimensionHeight.GetHashCode();
                if (this.SpringQuantity != null)
                    hashCode = hashCode * 59 + this.SpringQuantity.GetHashCode();
                if (this.TireQuantity != null)
                    hashCode = hashCode * 59 + this.TireQuantity.GetHashCode();
                if (this.TireSize != null)
                    hashCode = hashCode * 59 + this.TireSize.GetHashCode();
                if (this.FrontWheelTrack != null)
                    hashCode = hashCode * 59 + this.FrontWheelTrack.GetHashCode();
                if (this.RearWheelTrack != null)
                    hashCode = hashCode * 59 + this.RearWheelTrack.GetHashCode();
                if (this.Wheelbase != null)
                    hashCode = hashCode * 59 + this.Wheelbase.GetHashCode();
                if (this.AxleLoad != null)
                    hashCode = hashCode * 59 + this.AxleLoad.GetHashCode();
                if (this.AxleQuantity != null)
                    hashCode = hashCode * 59 + this.AxleQuantity.GetHashCode();
                if (this.SteeringForm != null)
                    hashCode = hashCode * 59 + this.SteeringForm.GetHashCode();
                if (this.TotalWeight != null)
                    hashCode = hashCode * 59 + this.TotalWeight.GetHashCode();
                if (this.EquipmentWeight != null)
                    hashCode = hashCode * 59 + this.EquipmentWeight.GetHashCode();
                if (this.MaximumLadenMass != null)
                    hashCode = hashCode * 59 + this.MaximumLadenMass.GetHashCode();
                if (this.MassUtilizationCoefficient != null)
                    hashCode = hashCode * 59 + this.MassUtilizationCoefficient.GetHashCode();
                if (this.TractionWeight != null)
                    hashCode = hashCode * 59 + this.TractionWeight.GetHashCode();
                if (this.MaximumLoadMass != null)
                    hashCode = hashCode * 59 + this.MaximumLoadMass.GetHashCode();
                if (this.CabPassengerCapacity != null)
                    hashCode = hashCode * 59 + this.CabPassengerCapacity.GetHashCode();
                if (this.PassengerCapacity != null)
                    hashCode = hashCode * 59 + this.PassengerCapacity.GetHashCode();
                if (this.MaxDesignSpeed != null)
                    hashCode = hashCode * 59 + this.MaxDesignSpeed.GetHashCode();
                if (this.ManufactureDate != null)
                    hashCode = hashCode * 59 + this.ManufactureDate.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.TextLocation != null)
                    hashCode = hashCode * 59 + this.TextLocation.GetHashCode();
                return hashCode;
            }
        }
    }
}
