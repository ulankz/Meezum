#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "System_Xml_System_Xml_Schema_XmlSchemaType1795078578.h"
#include "System_Xml_System_Xml_Schema_XmlSchemaDerivationMe3165007540.h"

// System.Xml.Schema.XmlSchemaSimpleType
struct XmlSchemaSimpleType_t248156492;
// System.Xml.Schema.XmlSchemaSimpleTypeContent
struct XmlSchemaSimpleTypeContent_t1606103299;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Schema.XmlSchemaSimpleType
struct  XmlSchemaSimpleType_t248156492  : public XmlSchemaType_t1795078578
{
public:
	// System.Xml.Schema.XmlSchemaSimpleTypeContent System.Xml.Schema.XmlSchemaSimpleType::content
	XmlSchemaSimpleTypeContent_t1606103299 * ___content_10;
	// System.Boolean System.Xml.Schema.XmlSchemaSimpleType::islocal
	bool ___islocal_11;
	// System.Xml.Schema.XmlSchemaDerivationMethod System.Xml.Schema.XmlSchemaSimpleType::variety
	int32_t ___variety_12;

public:
	inline static int32_t get_offset_of_content_10() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492, ___content_10)); }
	inline XmlSchemaSimpleTypeContent_t1606103299 * get_content_10() const { return ___content_10; }
	inline XmlSchemaSimpleTypeContent_t1606103299 ** get_address_of_content_10() { return &___content_10; }
	inline void set_content_10(XmlSchemaSimpleTypeContent_t1606103299 * value)
	{
		___content_10 = value;
		Il2CppCodeGenWriteBarrier(&___content_10, value);
	}

	inline static int32_t get_offset_of_islocal_11() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492, ___islocal_11)); }
	inline bool get_islocal_11() const { return ___islocal_11; }
	inline bool* get_address_of_islocal_11() { return &___islocal_11; }
	inline void set_islocal_11(bool value)
	{
		___islocal_11 = value;
	}

	inline static int32_t get_offset_of_variety_12() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492, ___variety_12)); }
	inline int32_t get_variety_12() const { return ___variety_12; }
	inline int32_t* get_address_of_variety_12() { return &___variety_12; }
	inline void set_variety_12(int32_t value)
	{
		___variety_12 = value;
	}
};

struct XmlSchemaSimpleType_t248156492_StaticFields
{
public:
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::schemaLocationType
	XmlSchemaSimpleType_t248156492 * ___schemaLocationType_9;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsAnySimpleType
	XmlSchemaSimpleType_t248156492 * ___XsAnySimpleType_13;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsString
	XmlSchemaSimpleType_t248156492 * ___XsString_14;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsBoolean
	XmlSchemaSimpleType_t248156492 * ___XsBoolean_15;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsDecimal
	XmlSchemaSimpleType_t248156492 * ___XsDecimal_16;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsFloat
	XmlSchemaSimpleType_t248156492 * ___XsFloat_17;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsDouble
	XmlSchemaSimpleType_t248156492 * ___XsDouble_18;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsDuration
	XmlSchemaSimpleType_t248156492 * ___XsDuration_19;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsDateTime
	XmlSchemaSimpleType_t248156492 * ___XsDateTime_20;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsTime
	XmlSchemaSimpleType_t248156492 * ___XsTime_21;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsDate
	XmlSchemaSimpleType_t248156492 * ___XsDate_22;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsGYearMonth
	XmlSchemaSimpleType_t248156492 * ___XsGYearMonth_23;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsGYear
	XmlSchemaSimpleType_t248156492 * ___XsGYear_24;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsGMonthDay
	XmlSchemaSimpleType_t248156492 * ___XsGMonthDay_25;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsGDay
	XmlSchemaSimpleType_t248156492 * ___XsGDay_26;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsGMonth
	XmlSchemaSimpleType_t248156492 * ___XsGMonth_27;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsHexBinary
	XmlSchemaSimpleType_t248156492 * ___XsHexBinary_28;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsBase64Binary
	XmlSchemaSimpleType_t248156492 * ___XsBase64Binary_29;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsAnyUri
	XmlSchemaSimpleType_t248156492 * ___XsAnyUri_30;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsQName
	XmlSchemaSimpleType_t248156492 * ___XsQName_31;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsNotation
	XmlSchemaSimpleType_t248156492 * ___XsNotation_32;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsNormalizedString
	XmlSchemaSimpleType_t248156492 * ___XsNormalizedString_33;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsToken
	XmlSchemaSimpleType_t248156492 * ___XsToken_34;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsLanguage
	XmlSchemaSimpleType_t248156492 * ___XsLanguage_35;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsNMToken
	XmlSchemaSimpleType_t248156492 * ___XsNMToken_36;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsNMTokens
	XmlSchemaSimpleType_t248156492 * ___XsNMTokens_37;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsName
	XmlSchemaSimpleType_t248156492 * ___XsName_38;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsNCName
	XmlSchemaSimpleType_t248156492 * ___XsNCName_39;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsID
	XmlSchemaSimpleType_t248156492 * ___XsID_40;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsIDRef
	XmlSchemaSimpleType_t248156492 * ___XsIDRef_41;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsIDRefs
	XmlSchemaSimpleType_t248156492 * ___XsIDRefs_42;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsEntity
	XmlSchemaSimpleType_t248156492 * ___XsEntity_43;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsEntities
	XmlSchemaSimpleType_t248156492 * ___XsEntities_44;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsInteger
	XmlSchemaSimpleType_t248156492 * ___XsInteger_45;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsNonPositiveInteger
	XmlSchemaSimpleType_t248156492 * ___XsNonPositiveInteger_46;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsNegativeInteger
	XmlSchemaSimpleType_t248156492 * ___XsNegativeInteger_47;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsLong
	XmlSchemaSimpleType_t248156492 * ___XsLong_48;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsInt
	XmlSchemaSimpleType_t248156492 * ___XsInt_49;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsShort
	XmlSchemaSimpleType_t248156492 * ___XsShort_50;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsByte
	XmlSchemaSimpleType_t248156492 * ___XsByte_51;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsNonNegativeInteger
	XmlSchemaSimpleType_t248156492 * ___XsNonNegativeInteger_52;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsUnsignedLong
	XmlSchemaSimpleType_t248156492 * ___XsUnsignedLong_53;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsUnsignedInt
	XmlSchemaSimpleType_t248156492 * ___XsUnsignedInt_54;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsUnsignedShort
	XmlSchemaSimpleType_t248156492 * ___XsUnsignedShort_55;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsUnsignedByte
	XmlSchemaSimpleType_t248156492 * ___XsUnsignedByte_56;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XsPositiveInteger
	XmlSchemaSimpleType_t248156492 * ___XsPositiveInteger_57;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XdtUntypedAtomic
	XmlSchemaSimpleType_t248156492 * ___XdtUntypedAtomic_58;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XdtAnyAtomicType
	XmlSchemaSimpleType_t248156492 * ___XdtAnyAtomicType_59;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XdtYearMonthDuration
	XmlSchemaSimpleType_t248156492 * ___XdtYearMonthDuration_60;
	// System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.XmlSchemaSimpleType::XdtDayTimeDuration
	XmlSchemaSimpleType_t248156492 * ___XdtDayTimeDuration_61;

public:
	inline static int32_t get_offset_of_schemaLocationType_9() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___schemaLocationType_9)); }
	inline XmlSchemaSimpleType_t248156492 * get_schemaLocationType_9() const { return ___schemaLocationType_9; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_schemaLocationType_9() { return &___schemaLocationType_9; }
	inline void set_schemaLocationType_9(XmlSchemaSimpleType_t248156492 * value)
	{
		___schemaLocationType_9 = value;
		Il2CppCodeGenWriteBarrier(&___schemaLocationType_9, value);
	}

	inline static int32_t get_offset_of_XsAnySimpleType_13() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsAnySimpleType_13)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsAnySimpleType_13() const { return ___XsAnySimpleType_13; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsAnySimpleType_13() { return &___XsAnySimpleType_13; }
	inline void set_XsAnySimpleType_13(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsAnySimpleType_13 = value;
		Il2CppCodeGenWriteBarrier(&___XsAnySimpleType_13, value);
	}

	inline static int32_t get_offset_of_XsString_14() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsString_14)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsString_14() const { return ___XsString_14; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsString_14() { return &___XsString_14; }
	inline void set_XsString_14(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsString_14 = value;
		Il2CppCodeGenWriteBarrier(&___XsString_14, value);
	}

	inline static int32_t get_offset_of_XsBoolean_15() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsBoolean_15)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsBoolean_15() const { return ___XsBoolean_15; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsBoolean_15() { return &___XsBoolean_15; }
	inline void set_XsBoolean_15(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsBoolean_15 = value;
		Il2CppCodeGenWriteBarrier(&___XsBoolean_15, value);
	}

	inline static int32_t get_offset_of_XsDecimal_16() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsDecimal_16)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsDecimal_16() const { return ___XsDecimal_16; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsDecimal_16() { return &___XsDecimal_16; }
	inline void set_XsDecimal_16(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsDecimal_16 = value;
		Il2CppCodeGenWriteBarrier(&___XsDecimal_16, value);
	}

	inline static int32_t get_offset_of_XsFloat_17() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsFloat_17)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsFloat_17() const { return ___XsFloat_17; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsFloat_17() { return &___XsFloat_17; }
	inline void set_XsFloat_17(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsFloat_17 = value;
		Il2CppCodeGenWriteBarrier(&___XsFloat_17, value);
	}

	inline static int32_t get_offset_of_XsDouble_18() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsDouble_18)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsDouble_18() const { return ___XsDouble_18; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsDouble_18() { return &___XsDouble_18; }
	inline void set_XsDouble_18(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsDouble_18 = value;
		Il2CppCodeGenWriteBarrier(&___XsDouble_18, value);
	}

	inline static int32_t get_offset_of_XsDuration_19() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsDuration_19)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsDuration_19() const { return ___XsDuration_19; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsDuration_19() { return &___XsDuration_19; }
	inline void set_XsDuration_19(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsDuration_19 = value;
		Il2CppCodeGenWriteBarrier(&___XsDuration_19, value);
	}

	inline static int32_t get_offset_of_XsDateTime_20() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsDateTime_20)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsDateTime_20() const { return ___XsDateTime_20; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsDateTime_20() { return &___XsDateTime_20; }
	inline void set_XsDateTime_20(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsDateTime_20 = value;
		Il2CppCodeGenWriteBarrier(&___XsDateTime_20, value);
	}

	inline static int32_t get_offset_of_XsTime_21() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsTime_21)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsTime_21() const { return ___XsTime_21; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsTime_21() { return &___XsTime_21; }
	inline void set_XsTime_21(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsTime_21 = value;
		Il2CppCodeGenWriteBarrier(&___XsTime_21, value);
	}

	inline static int32_t get_offset_of_XsDate_22() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsDate_22)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsDate_22() const { return ___XsDate_22; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsDate_22() { return &___XsDate_22; }
	inline void set_XsDate_22(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsDate_22 = value;
		Il2CppCodeGenWriteBarrier(&___XsDate_22, value);
	}

	inline static int32_t get_offset_of_XsGYearMonth_23() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsGYearMonth_23)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsGYearMonth_23() const { return ___XsGYearMonth_23; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsGYearMonth_23() { return &___XsGYearMonth_23; }
	inline void set_XsGYearMonth_23(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsGYearMonth_23 = value;
		Il2CppCodeGenWriteBarrier(&___XsGYearMonth_23, value);
	}

	inline static int32_t get_offset_of_XsGYear_24() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsGYear_24)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsGYear_24() const { return ___XsGYear_24; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsGYear_24() { return &___XsGYear_24; }
	inline void set_XsGYear_24(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsGYear_24 = value;
		Il2CppCodeGenWriteBarrier(&___XsGYear_24, value);
	}

	inline static int32_t get_offset_of_XsGMonthDay_25() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsGMonthDay_25)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsGMonthDay_25() const { return ___XsGMonthDay_25; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsGMonthDay_25() { return &___XsGMonthDay_25; }
	inline void set_XsGMonthDay_25(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsGMonthDay_25 = value;
		Il2CppCodeGenWriteBarrier(&___XsGMonthDay_25, value);
	}

	inline static int32_t get_offset_of_XsGDay_26() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsGDay_26)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsGDay_26() const { return ___XsGDay_26; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsGDay_26() { return &___XsGDay_26; }
	inline void set_XsGDay_26(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsGDay_26 = value;
		Il2CppCodeGenWriteBarrier(&___XsGDay_26, value);
	}

	inline static int32_t get_offset_of_XsGMonth_27() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsGMonth_27)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsGMonth_27() const { return ___XsGMonth_27; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsGMonth_27() { return &___XsGMonth_27; }
	inline void set_XsGMonth_27(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsGMonth_27 = value;
		Il2CppCodeGenWriteBarrier(&___XsGMonth_27, value);
	}

	inline static int32_t get_offset_of_XsHexBinary_28() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsHexBinary_28)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsHexBinary_28() const { return ___XsHexBinary_28; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsHexBinary_28() { return &___XsHexBinary_28; }
	inline void set_XsHexBinary_28(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsHexBinary_28 = value;
		Il2CppCodeGenWriteBarrier(&___XsHexBinary_28, value);
	}

	inline static int32_t get_offset_of_XsBase64Binary_29() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsBase64Binary_29)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsBase64Binary_29() const { return ___XsBase64Binary_29; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsBase64Binary_29() { return &___XsBase64Binary_29; }
	inline void set_XsBase64Binary_29(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsBase64Binary_29 = value;
		Il2CppCodeGenWriteBarrier(&___XsBase64Binary_29, value);
	}

	inline static int32_t get_offset_of_XsAnyUri_30() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsAnyUri_30)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsAnyUri_30() const { return ___XsAnyUri_30; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsAnyUri_30() { return &___XsAnyUri_30; }
	inline void set_XsAnyUri_30(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsAnyUri_30 = value;
		Il2CppCodeGenWriteBarrier(&___XsAnyUri_30, value);
	}

	inline static int32_t get_offset_of_XsQName_31() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsQName_31)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsQName_31() const { return ___XsQName_31; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsQName_31() { return &___XsQName_31; }
	inline void set_XsQName_31(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsQName_31 = value;
		Il2CppCodeGenWriteBarrier(&___XsQName_31, value);
	}

	inline static int32_t get_offset_of_XsNotation_32() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsNotation_32)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsNotation_32() const { return ___XsNotation_32; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsNotation_32() { return &___XsNotation_32; }
	inline void set_XsNotation_32(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsNotation_32 = value;
		Il2CppCodeGenWriteBarrier(&___XsNotation_32, value);
	}

	inline static int32_t get_offset_of_XsNormalizedString_33() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsNormalizedString_33)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsNormalizedString_33() const { return ___XsNormalizedString_33; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsNormalizedString_33() { return &___XsNormalizedString_33; }
	inline void set_XsNormalizedString_33(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsNormalizedString_33 = value;
		Il2CppCodeGenWriteBarrier(&___XsNormalizedString_33, value);
	}

	inline static int32_t get_offset_of_XsToken_34() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsToken_34)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsToken_34() const { return ___XsToken_34; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsToken_34() { return &___XsToken_34; }
	inline void set_XsToken_34(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsToken_34 = value;
		Il2CppCodeGenWriteBarrier(&___XsToken_34, value);
	}

	inline static int32_t get_offset_of_XsLanguage_35() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsLanguage_35)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsLanguage_35() const { return ___XsLanguage_35; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsLanguage_35() { return &___XsLanguage_35; }
	inline void set_XsLanguage_35(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsLanguage_35 = value;
		Il2CppCodeGenWriteBarrier(&___XsLanguage_35, value);
	}

	inline static int32_t get_offset_of_XsNMToken_36() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsNMToken_36)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsNMToken_36() const { return ___XsNMToken_36; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsNMToken_36() { return &___XsNMToken_36; }
	inline void set_XsNMToken_36(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsNMToken_36 = value;
		Il2CppCodeGenWriteBarrier(&___XsNMToken_36, value);
	}

	inline static int32_t get_offset_of_XsNMTokens_37() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsNMTokens_37)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsNMTokens_37() const { return ___XsNMTokens_37; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsNMTokens_37() { return &___XsNMTokens_37; }
	inline void set_XsNMTokens_37(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsNMTokens_37 = value;
		Il2CppCodeGenWriteBarrier(&___XsNMTokens_37, value);
	}

	inline static int32_t get_offset_of_XsName_38() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsName_38)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsName_38() const { return ___XsName_38; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsName_38() { return &___XsName_38; }
	inline void set_XsName_38(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsName_38 = value;
		Il2CppCodeGenWriteBarrier(&___XsName_38, value);
	}

	inline static int32_t get_offset_of_XsNCName_39() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsNCName_39)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsNCName_39() const { return ___XsNCName_39; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsNCName_39() { return &___XsNCName_39; }
	inline void set_XsNCName_39(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsNCName_39 = value;
		Il2CppCodeGenWriteBarrier(&___XsNCName_39, value);
	}

	inline static int32_t get_offset_of_XsID_40() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsID_40)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsID_40() const { return ___XsID_40; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsID_40() { return &___XsID_40; }
	inline void set_XsID_40(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsID_40 = value;
		Il2CppCodeGenWriteBarrier(&___XsID_40, value);
	}

	inline static int32_t get_offset_of_XsIDRef_41() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsIDRef_41)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsIDRef_41() const { return ___XsIDRef_41; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsIDRef_41() { return &___XsIDRef_41; }
	inline void set_XsIDRef_41(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsIDRef_41 = value;
		Il2CppCodeGenWriteBarrier(&___XsIDRef_41, value);
	}

	inline static int32_t get_offset_of_XsIDRefs_42() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsIDRefs_42)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsIDRefs_42() const { return ___XsIDRefs_42; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsIDRefs_42() { return &___XsIDRefs_42; }
	inline void set_XsIDRefs_42(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsIDRefs_42 = value;
		Il2CppCodeGenWriteBarrier(&___XsIDRefs_42, value);
	}

	inline static int32_t get_offset_of_XsEntity_43() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsEntity_43)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsEntity_43() const { return ___XsEntity_43; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsEntity_43() { return &___XsEntity_43; }
	inline void set_XsEntity_43(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsEntity_43 = value;
		Il2CppCodeGenWriteBarrier(&___XsEntity_43, value);
	}

	inline static int32_t get_offset_of_XsEntities_44() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsEntities_44)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsEntities_44() const { return ___XsEntities_44; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsEntities_44() { return &___XsEntities_44; }
	inline void set_XsEntities_44(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsEntities_44 = value;
		Il2CppCodeGenWriteBarrier(&___XsEntities_44, value);
	}

	inline static int32_t get_offset_of_XsInteger_45() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsInteger_45)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsInteger_45() const { return ___XsInteger_45; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsInteger_45() { return &___XsInteger_45; }
	inline void set_XsInteger_45(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsInteger_45 = value;
		Il2CppCodeGenWriteBarrier(&___XsInteger_45, value);
	}

	inline static int32_t get_offset_of_XsNonPositiveInteger_46() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsNonPositiveInteger_46)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsNonPositiveInteger_46() const { return ___XsNonPositiveInteger_46; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsNonPositiveInteger_46() { return &___XsNonPositiveInteger_46; }
	inline void set_XsNonPositiveInteger_46(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsNonPositiveInteger_46 = value;
		Il2CppCodeGenWriteBarrier(&___XsNonPositiveInteger_46, value);
	}

	inline static int32_t get_offset_of_XsNegativeInteger_47() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsNegativeInteger_47)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsNegativeInteger_47() const { return ___XsNegativeInteger_47; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsNegativeInteger_47() { return &___XsNegativeInteger_47; }
	inline void set_XsNegativeInteger_47(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsNegativeInteger_47 = value;
		Il2CppCodeGenWriteBarrier(&___XsNegativeInteger_47, value);
	}

	inline static int32_t get_offset_of_XsLong_48() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsLong_48)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsLong_48() const { return ___XsLong_48; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsLong_48() { return &___XsLong_48; }
	inline void set_XsLong_48(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsLong_48 = value;
		Il2CppCodeGenWriteBarrier(&___XsLong_48, value);
	}

	inline static int32_t get_offset_of_XsInt_49() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsInt_49)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsInt_49() const { return ___XsInt_49; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsInt_49() { return &___XsInt_49; }
	inline void set_XsInt_49(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsInt_49 = value;
		Il2CppCodeGenWriteBarrier(&___XsInt_49, value);
	}

	inline static int32_t get_offset_of_XsShort_50() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsShort_50)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsShort_50() const { return ___XsShort_50; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsShort_50() { return &___XsShort_50; }
	inline void set_XsShort_50(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsShort_50 = value;
		Il2CppCodeGenWriteBarrier(&___XsShort_50, value);
	}

	inline static int32_t get_offset_of_XsByte_51() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsByte_51)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsByte_51() const { return ___XsByte_51; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsByte_51() { return &___XsByte_51; }
	inline void set_XsByte_51(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsByte_51 = value;
		Il2CppCodeGenWriteBarrier(&___XsByte_51, value);
	}

	inline static int32_t get_offset_of_XsNonNegativeInteger_52() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsNonNegativeInteger_52)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsNonNegativeInteger_52() const { return ___XsNonNegativeInteger_52; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsNonNegativeInteger_52() { return &___XsNonNegativeInteger_52; }
	inline void set_XsNonNegativeInteger_52(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsNonNegativeInteger_52 = value;
		Il2CppCodeGenWriteBarrier(&___XsNonNegativeInteger_52, value);
	}

	inline static int32_t get_offset_of_XsUnsignedLong_53() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsUnsignedLong_53)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsUnsignedLong_53() const { return ___XsUnsignedLong_53; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsUnsignedLong_53() { return &___XsUnsignedLong_53; }
	inline void set_XsUnsignedLong_53(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsUnsignedLong_53 = value;
		Il2CppCodeGenWriteBarrier(&___XsUnsignedLong_53, value);
	}

	inline static int32_t get_offset_of_XsUnsignedInt_54() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsUnsignedInt_54)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsUnsignedInt_54() const { return ___XsUnsignedInt_54; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsUnsignedInt_54() { return &___XsUnsignedInt_54; }
	inline void set_XsUnsignedInt_54(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsUnsignedInt_54 = value;
		Il2CppCodeGenWriteBarrier(&___XsUnsignedInt_54, value);
	}

	inline static int32_t get_offset_of_XsUnsignedShort_55() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsUnsignedShort_55)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsUnsignedShort_55() const { return ___XsUnsignedShort_55; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsUnsignedShort_55() { return &___XsUnsignedShort_55; }
	inline void set_XsUnsignedShort_55(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsUnsignedShort_55 = value;
		Il2CppCodeGenWriteBarrier(&___XsUnsignedShort_55, value);
	}

	inline static int32_t get_offset_of_XsUnsignedByte_56() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsUnsignedByte_56)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsUnsignedByte_56() const { return ___XsUnsignedByte_56; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsUnsignedByte_56() { return &___XsUnsignedByte_56; }
	inline void set_XsUnsignedByte_56(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsUnsignedByte_56 = value;
		Il2CppCodeGenWriteBarrier(&___XsUnsignedByte_56, value);
	}

	inline static int32_t get_offset_of_XsPositiveInteger_57() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XsPositiveInteger_57)); }
	inline XmlSchemaSimpleType_t248156492 * get_XsPositiveInteger_57() const { return ___XsPositiveInteger_57; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XsPositiveInteger_57() { return &___XsPositiveInteger_57; }
	inline void set_XsPositiveInteger_57(XmlSchemaSimpleType_t248156492 * value)
	{
		___XsPositiveInteger_57 = value;
		Il2CppCodeGenWriteBarrier(&___XsPositiveInteger_57, value);
	}

	inline static int32_t get_offset_of_XdtUntypedAtomic_58() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XdtUntypedAtomic_58)); }
	inline XmlSchemaSimpleType_t248156492 * get_XdtUntypedAtomic_58() const { return ___XdtUntypedAtomic_58; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XdtUntypedAtomic_58() { return &___XdtUntypedAtomic_58; }
	inline void set_XdtUntypedAtomic_58(XmlSchemaSimpleType_t248156492 * value)
	{
		___XdtUntypedAtomic_58 = value;
		Il2CppCodeGenWriteBarrier(&___XdtUntypedAtomic_58, value);
	}

	inline static int32_t get_offset_of_XdtAnyAtomicType_59() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XdtAnyAtomicType_59)); }
	inline XmlSchemaSimpleType_t248156492 * get_XdtAnyAtomicType_59() const { return ___XdtAnyAtomicType_59; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XdtAnyAtomicType_59() { return &___XdtAnyAtomicType_59; }
	inline void set_XdtAnyAtomicType_59(XmlSchemaSimpleType_t248156492 * value)
	{
		___XdtAnyAtomicType_59 = value;
		Il2CppCodeGenWriteBarrier(&___XdtAnyAtomicType_59, value);
	}

	inline static int32_t get_offset_of_XdtYearMonthDuration_60() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XdtYearMonthDuration_60)); }
	inline XmlSchemaSimpleType_t248156492 * get_XdtYearMonthDuration_60() const { return ___XdtYearMonthDuration_60; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XdtYearMonthDuration_60() { return &___XdtYearMonthDuration_60; }
	inline void set_XdtYearMonthDuration_60(XmlSchemaSimpleType_t248156492 * value)
	{
		___XdtYearMonthDuration_60 = value;
		Il2CppCodeGenWriteBarrier(&___XdtYearMonthDuration_60, value);
	}

	inline static int32_t get_offset_of_XdtDayTimeDuration_61() { return static_cast<int32_t>(offsetof(XmlSchemaSimpleType_t248156492_StaticFields, ___XdtDayTimeDuration_61)); }
	inline XmlSchemaSimpleType_t248156492 * get_XdtDayTimeDuration_61() const { return ___XdtDayTimeDuration_61; }
	inline XmlSchemaSimpleType_t248156492 ** get_address_of_XdtDayTimeDuration_61() { return &___XdtDayTimeDuration_61; }
	inline void set_XdtDayTimeDuration_61(XmlSchemaSimpleType_t248156492 * value)
	{
		___XdtDayTimeDuration_61 = value;
		Il2CppCodeGenWriteBarrier(&___XdtDayTimeDuration_61, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
