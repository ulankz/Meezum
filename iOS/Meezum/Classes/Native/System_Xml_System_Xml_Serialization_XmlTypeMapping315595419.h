#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "System_Xml_System_Xml_Serialization_XmlMapping1597064667.h"

// System.String
struct String_t;
// System.Xml.Serialization.TypeData
struct TypeData_t3979356678;
// System.Xml.Serialization.XmlTypeMapping
struct XmlTypeMapping_t315595419;
// System.Collections.ArrayList
struct ArrayList_t4252133567;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.XmlTypeMapping
struct  XmlTypeMapping_t315595419  : public XmlMapping_t1597064667
{
public:
	// System.String System.Xml.Serialization.XmlTypeMapping::xmlType
	String_t* ___xmlType_7;
	// System.String System.Xml.Serialization.XmlTypeMapping::xmlTypeNamespace
	String_t* ___xmlTypeNamespace_8;
	// System.Xml.Serialization.TypeData System.Xml.Serialization.XmlTypeMapping::type
	TypeData_t3979356678 * ___type_9;
	// System.Xml.Serialization.XmlTypeMapping System.Xml.Serialization.XmlTypeMapping::baseMap
	XmlTypeMapping_t315595419 * ___baseMap_10;
	// System.Boolean System.Xml.Serialization.XmlTypeMapping::multiReferenceType
	bool ___multiReferenceType_11;
	// System.Boolean System.Xml.Serialization.XmlTypeMapping::includeInSchema
	bool ___includeInSchema_12;
	// System.Boolean System.Xml.Serialization.XmlTypeMapping::isNullable
	bool ___isNullable_13;
	// System.Collections.ArrayList System.Xml.Serialization.XmlTypeMapping::_derivedTypes
	ArrayList_t4252133567 * ____derivedTypes_14;

public:
	inline static int32_t get_offset_of_xmlType_7() { return static_cast<int32_t>(offsetof(XmlTypeMapping_t315595419, ___xmlType_7)); }
	inline String_t* get_xmlType_7() const { return ___xmlType_7; }
	inline String_t** get_address_of_xmlType_7() { return &___xmlType_7; }
	inline void set_xmlType_7(String_t* value)
	{
		___xmlType_7 = value;
		Il2CppCodeGenWriteBarrier(&___xmlType_7, value);
	}

	inline static int32_t get_offset_of_xmlTypeNamespace_8() { return static_cast<int32_t>(offsetof(XmlTypeMapping_t315595419, ___xmlTypeNamespace_8)); }
	inline String_t* get_xmlTypeNamespace_8() const { return ___xmlTypeNamespace_8; }
	inline String_t** get_address_of_xmlTypeNamespace_8() { return &___xmlTypeNamespace_8; }
	inline void set_xmlTypeNamespace_8(String_t* value)
	{
		___xmlTypeNamespace_8 = value;
		Il2CppCodeGenWriteBarrier(&___xmlTypeNamespace_8, value);
	}

	inline static int32_t get_offset_of_type_9() { return static_cast<int32_t>(offsetof(XmlTypeMapping_t315595419, ___type_9)); }
	inline TypeData_t3979356678 * get_type_9() const { return ___type_9; }
	inline TypeData_t3979356678 ** get_address_of_type_9() { return &___type_9; }
	inline void set_type_9(TypeData_t3979356678 * value)
	{
		___type_9 = value;
		Il2CppCodeGenWriteBarrier(&___type_9, value);
	}

	inline static int32_t get_offset_of_baseMap_10() { return static_cast<int32_t>(offsetof(XmlTypeMapping_t315595419, ___baseMap_10)); }
	inline XmlTypeMapping_t315595419 * get_baseMap_10() const { return ___baseMap_10; }
	inline XmlTypeMapping_t315595419 ** get_address_of_baseMap_10() { return &___baseMap_10; }
	inline void set_baseMap_10(XmlTypeMapping_t315595419 * value)
	{
		___baseMap_10 = value;
		Il2CppCodeGenWriteBarrier(&___baseMap_10, value);
	}

	inline static int32_t get_offset_of_multiReferenceType_11() { return static_cast<int32_t>(offsetof(XmlTypeMapping_t315595419, ___multiReferenceType_11)); }
	inline bool get_multiReferenceType_11() const { return ___multiReferenceType_11; }
	inline bool* get_address_of_multiReferenceType_11() { return &___multiReferenceType_11; }
	inline void set_multiReferenceType_11(bool value)
	{
		___multiReferenceType_11 = value;
	}

	inline static int32_t get_offset_of_includeInSchema_12() { return static_cast<int32_t>(offsetof(XmlTypeMapping_t315595419, ___includeInSchema_12)); }
	inline bool get_includeInSchema_12() const { return ___includeInSchema_12; }
	inline bool* get_address_of_includeInSchema_12() { return &___includeInSchema_12; }
	inline void set_includeInSchema_12(bool value)
	{
		___includeInSchema_12 = value;
	}

	inline static int32_t get_offset_of_isNullable_13() { return static_cast<int32_t>(offsetof(XmlTypeMapping_t315595419, ___isNullable_13)); }
	inline bool get_isNullable_13() const { return ___isNullable_13; }
	inline bool* get_address_of_isNullable_13() { return &___isNullable_13; }
	inline void set_isNullable_13(bool value)
	{
		___isNullable_13 = value;
	}

	inline static int32_t get_offset_of__derivedTypes_14() { return static_cast<int32_t>(offsetof(XmlTypeMapping_t315595419, ____derivedTypes_14)); }
	inline ArrayList_t4252133567 * get__derivedTypes_14() const { return ____derivedTypes_14; }
	inline ArrayList_t4252133567 ** get_address_of__derivedTypes_14() { return &____derivedTypes_14; }
	inline void set__derivedTypes_14(ArrayList_t4252133567 * value)
	{
		____derivedTypes_14 = value;
		Il2CppCodeGenWriteBarrier(&____derivedTypes_14, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
