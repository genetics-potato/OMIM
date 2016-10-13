Imports Microsoft.VisualBasic.Serialization.JSON

Namespace Handlers.clinicalSynopsis

    Public Class clinicalSynopsisData

        Public Property oldFormatExists As Boolean
        Public Property mimNumber As String
        Public Property prefix As String
        ''' <summary>
        ''' Title taken from the mim entry
        ''' </summary>
        ''' <returns></returns>
        Public Property preferredTitle As String
        ''' <summary>
        ''' Features In all fields are delimited With ';'
        ''' And include IDs for UMLS, SNOMEDCT,
        ''' ICD10CM, ICD9CM And HPO
        ''' </summary>
        ''' <returns></returns>
        Public Property inheritance As String
        Public Property growth As String
        Public Property growthHeight As String
        Public Property growthWeight As String
        Public Property growthOther As String
        Public Property headAndNeck As String
        Public Property headAndNeckHead As String
        Public Property headAndNeckFace As String
        Public Property headAndNeckEars As String
        Public Property headAndNeckEyes As String
        Public Property headAndNeckNose As String
        Public Property headAndNeckMouth As String
        Public Property headAndNeckTeeth As String
        Public Property headAndNeckNeck As String
        Public Property cardiovascular As String
        Public Property cardiovascularHeart As String
        Public Property cardiovascularVascular As String
        Public Property respiratory As String
        Public Property respiratoryNasopharynx As String
        Public Property respiratoryLarynx As String
        Public Property respiratoryAirways As String
        Public Property respiratoryLung As String
        Public Property chest As String
        Public Property chestExternalFeatures As String
        Public Property chestRibsSternumClaviclesAndScapulae As String
        Public Property chestBreasts As String
        Public Property chestDiaphragm As String
        Public Property abdomen As String
        Public Property abdomenExternalFeatures As String
        Public Property abdomenLiver As String
        Public Property abdomenPancreas As String
        Public Property abdomenBiliaryTract As String
        Public Property abdomenSpleen As String
        Public Property abdomenGastrointestinal As String
        Public Property genitourinary As String
        Public Property genitourinaryExternalGenitaliaMale As String
        Public Property genitourinaryExternalGenitaliaFemale As String
        Public Property genitourinaryInternalGenitaliaMale As String
        Public Property genitourinaryInternalGenitaliaFemale As String
        Public Property genitourinaryKidneys As String
        Public Property genitourinaryUreters As String
        Public Property genitourinaryBladder As String
        Public Property skeletal As String
        Public Property skeletalSkull As String
        Public Property skeletalSpine As String
        Public Property skeletalPelvis As String
        Public Property skeletalLimbs As String
        Public Property skeletalHands As String
        Public Property skeletalFeet As String
        Public Property skinNailsHair As String
        Public Property skinNailsHairSkin As String
        Public Property skinNailsHairSkinHistology As String
        Public Property skinNailsHairSkinElectronMicroscopy As String
        Public Property skinNailsHairNails As String
        Public Property skinNailsHairHair As String
        Public Property muscleSoftTissue As String
        Public Property neurologic As String
        Public Property neurologicCentralNervousSystem As String
        Public Property neurologicPeripheralNervousSystem As String
        Public Property neurologicBehavioralPsychiatricManifestations As String
        Public Property voice As String
        Public Property metabolicFeatures As String
        Public Property endocrineFeatures As String
        Public Property hematology As String
        Public Property immunology As String
        Public Property neoplasia As String
        Public Property prenatalManifestations As String
        Public Property prenatalManifestationsMovement As String
        Public Property prenatalManifestationsAmnioticFluid As String
        Public Property prenatalManifestationsPlacentaAndUmbilicalCord As String
        Public Property prenatalManifestationsMaternal As String
        Public Property prenatalManifestationsDelivery As String
        Public Property laboratoryAbnormalities As String
        Public Property miscellaneous As String
        Public Property molecularBasis As String
        ''' <summary>
        ''' true if this contains data (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property inheritanceExists As String
        ''' <summary>
        ''' true if this And any its subheadings contain data (i)
        ''' </summary>
        ''' <returns></returns>
        Public Property growthExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property growthHeightExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property growthWeightExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property growthOtherExists As String
        ''' <summary>
        ''' (i)
        ''' </summary>
        ''' <returns></returns>
        Public Property headAndNeckExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property headAndNeckHeadExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property headAndNeckFaceExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property headAndNeckEarsExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property headAndNeckEyesExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property headAndNeckNoseExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property headAndNeckMouthExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property headAndNeckTeethExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property headAndNeckNeckExists As String
        ''' <summary>
        ''' (i)
        ''' </summary>
        ''' <returns></returns>
        Public Property cardiovascularExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property cardiovascularHeartExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property cardiovascularVascularExists As String
        ''' <summary>
        ''' (i)
        ''' </summary>
        ''' <returns></returns>
        Public Property respiratoryExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property respiratoryNasopharynxExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property respiratoryLarynxExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property respiratoryAirwaysExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property respiratoryLungExists As String
        ''' <summary>
        ''' (i)
        ''' </summary>
        ''' <returns></returns>
        Public Property chestExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property chestExternalFeaturesExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property chestRibsSternumClaviclesAndScapulaeExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property chestBreastsExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property chestDiaphragmExists As String
        ''' <summary>
        ''' (i)
        ''' </summary>
        ''' <returns></returns>
        Public Property abdomenExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property abdomenExternalFeaturesExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property abdomenLiverExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property abdomenPancreasExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property abdomenBiliaryTractExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property abdomenSpleenExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property abdomenGastrointestinalExists As String
        ''' <summary>
        ''' (i)
        ''' </summary>
        ''' <returns></returns>
        Public Property genitourinaryExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property genitourinaryExternalGenitaliaMaleExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property genitourinaryExternalGenitaliaFemaleExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property genitourinaryInternalGenitaliaMaleExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property genitourinaryInternalGenitaliaFemaleExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property genitourinaryKidneysExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property genitourinaryUretersExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property genitourinaryBladderExists As String
        ''' <summary>
        ''' (i)
        ''' </summary>
        ''' <returns></returns>
        Public Property skeletalExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property skeletalSkullExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property skeletalSpineExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property skeletalPelvisExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property skeletalLimbsExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property skeletalHandsExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property skeletalFeetExists As String
        ''' <summary>
        ''' (i)
        ''' </summary>
        ''' <returns></returns>
        Public Property skinNailsHairExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property skinNailsHairSkinExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property skinNailsHairSkinHistologyExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property skinNailsHairSkinElectronMicroscopyExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property skinNailsHairNailsExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property skinNailsHairHairExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property muscleSoftTissueExists As String
        ''' <summary>
        ''' (i)
        ''' </summary>
        ''' <returns></returns>
        Public Property neurologicExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property neurologicCentralNervousSystemExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property neurologicPeripheralNervousSystemExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property neurologicBehavioralPsychiatricManifestationsExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property voiceExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property metabolicFeaturesExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property endocrineFeaturesExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property hematologyExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property immunologyExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property neoplasiaExists As String
        ''' <summary>
        ''' (i)
        ''' </summary>
        ''' <returns></returns>
        Public Property prenatalManifestationsExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property prenatalManifestationsMovementExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property prenatalManifestationsAmnioticFluidExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property prenatalManifestationsPlacentaAndUmbilicalCordExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property prenatalManifestationsMaternalExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property prenatalManifestationsDeliveryExists As String
        ''' <summary>
        ''' (i)
        ''' </summary>
        ''' <returns></returns>
        Public Property laboratoryAbnormalitiesExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property miscellaneousExists As String
        ''' <summary>
        ''' (ii)
        ''' </summary>
        ''' <returns></returns>
        Public Property molecularBasisExists As String
        ''' <summary>
        ''' Old format clinical synopsis, will be remapped To New format
        ''' </summary>
        ''' <returns></returns>
        Public Property oldFormat As oldFormat
        ''' <summary>
        ''' See above For external links
        ''' </summary>
        ''' <returns></returns>
        Public Property externalLinks As String
        Public Property contributors As String
        Public Property creationDate As String
        Public Property editHistory As String
        ''' <summary>
        ''' Web Date
        ''' </summary>
        ''' <returns></returns>
        Public Property dateCreated As String
        ''' <summary>
        ''' Unix epoch
        ''' </summary>
        ''' <returns></returns>
        Public Property epochCreated As String
        ''' <summary>
        ''' Web Date
        ''' </summary>
        ''' <returns></returns>
        Public Property dateUpdated As String
        ''' <summary>
        ''' Unix epoch
        ''' </summary>
        ''' <returns></returns>
        Public Property epochUpdated As String

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function
    End Class

    Public Class oldFormat
        Public Property Eyes As String
        Public Property Neuro As String
        Public Property Inheritance As String

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function
    End Class
End Namespace