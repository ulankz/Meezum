#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object2689449295.h"
#include "System_Xml_System_Xml_Schema_XmlSchemaForm1143227640.h"

// System.String
struct String_t;
// System.Xml.Serialization.XmlTypeMapMember
struct XmlTypeMapMember_t3057402259;
// System.Object
struct Il2CppObject;
// System.Xml.Serialization.XmlTypeMapping
struct XmlTypeMapping_t315595419;
// System.Xml.Serialization.TypeData
struct TypeData_t3979356678;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.XmlTypeMapElementInfo
struct  XmlTypeMapElementInfo_t3381496463  : public Il2CppObject
{
public:
	// System.String System.Xml.Serialization.XmlTypeMapElementInfo::_elementName
	String_t* ____elementName_0;
	// System.String System.Xml.Serialization.XmlTypeMapElementInfo::_namespace
	String_t* ____namespace_1;
	// System.Xml.Schema.XmlSchemaForm System.Xml.Serialization.XmlTypeMapElementInfo::_form
	int32_t ____form_2;
	// System.Xml.Serialization.XmlTypeMapMember System.Xml.Serialization.XmlTypeMapElementInfo::_member
	XmlTypeMapMember_t3057402259 * ____member_3;
	// System.Object System.Xml.Serialization.XmlTypeMapElementInfo::_choiceValue
	Il2CppObject * ____choiceValue_4;
	// System.Boolean System.Xml.Serialization.XmlTypeMapElementInfo::_isNullable
	bool ____isNullable_5;
	// System.Int32 System.Xml.Serialization.XmlTypeMapElementInfo::_nestingLevel
	int32_t ____nestingLevel_6;
	// System.Xml.Serialization.XmlTypeMapping System.Xml.Serialization.XmlTypeMapElementInfo::_mappedType
	XmlTypeMapping_t315595419 * ____mappedType_7;
	// System.Xml.Serialization.TypeData System.Xml.Serialization.XmlTypeMapElementInfo::_type
	TypeData_t3979356678 * ____type_8;
	// System.Boolean System.Xml.Serialization.XmlTypeMapElementInfo::_wrappedElement
	bool ____wrappedElement_9;

public:
	inline static int32_t get_offset_of__elementName_0() { return static_cast<int32_t>(offsetof(XmlTypeMapElementInfo_t3381496463, ____elementName_0)); }
	inline String_t* get__elementName_0() const { return ____elementName_0; }
	inline String_t** get_address_of__elementName_0() { return &____elementName_0; }
	inline void set__elementName_0(String_t* value)
	{
		____elementName_0 = value;
		Il2CppCodeGenWriteBarrier(&____elementName_0, value);
	}

	inline static int32_t get_offset_of__namespace_1() { return static_cast<int32_t>(offsetof(XmlTypeMapElementInfo_t3381496463, ____namespace_1)); }
	inline String_t* get__namespace_1() const { return ____namespace_1; }
	inline String_t** get_address_of__namespace_1() { return &____namespace_1; }
	inline void set__namespace_1(String_t* value)
	{
		____namespace_1 = value;
		Il2CppCodeGenWriteBarrier(&____namespace_1, value);
	}

	inline static int32_t get_offset_of__form_2() { return static_cast<int32_t>(offsetof(XmlTypeMapElementInfo_t3381496463, ____form_2)); }
	inline int32_t get__form_2() const { return ____form_2; }
	inline int32_t* get_address_of__form_2() { return &____form_2; }
	inline void set__form_2(int32_t value)
	{
		____form_2 = value;
	}

	inline static int32_t get_offset_of__member_3() { return static_cast<int32_t>(offsetof(XmlTypeMapElementInfo_t3381496463, ____member_3)); }
	inline XmlTypeMapMember_t3057402259 * get__member_3() const { return ____member_3; }
	inline XmlTypeMapMember_t3057402259 ** get_address_of__member_3() { return &____member_3; }
	inline void set__member_3(XmlTypeMapMember_t3057402259 * value)
	{
		____member_3 = value;
		Il2CppCodeGenWriteBarrier(&____member_3, value);
	}

	inline static int32_t get_offset_of__choiceValue_4() { return static_cast<int32_t>(offsetof(XmlTypeMapElementInfo_t3381496463, ____choiceValue_4)); }
	inline Il2CppObject * get__choiceValue_4() const { return ____choiceValue_4; }
	inline Il2CppObject ** get_address_of__choiceValue_4() { return &____choiceValue_4; }
	inline void set__choiceValue_4(Il2CppObject * value)
	{
		____choiceValue_4 = value;
		Il2CppCodeGenWriteBarrier(&____choiceValue_4, value);
	}

	inline static int32_t get_offset_of__isNullable_5() { return static_cast<int32_t>(offsetof(XmlTypeMapElementInfo_t3381496463, ____isNullable_5)); }
	inline bool get__isNullable_5() const { return ____isNullable_5; }
	inline bool* get_address_of__isNullable_5() { return &____isNullable_5; }
	inline void set__isNullable_5(bool value)
	{
		____isNullable_5 = value;
	}

	inline static int32_t get_offset_of__nestingLevel_6() { return static_cast<int32_t>(offsetof(XmlTypeMapElementInfo_t3381496463, ____nestingLevel_6)); }
	inline int32_t get__nestingLevel_6() const { return ____nestingLevel_6; }
	inline int32_t* get_address_of__nestingLevel_6() { return &____nestingLevel_6; }
	inline void set__nestingLevel_6(int32_t value)
	{
		____nestingLevel_6 = value;
	}

	inline static int32_t get_offset_of__mappedType_7() { return static_cast<int32_t>(offsetof(XmlTypeMapElementInfo_t3381496463, ____mappedType_7)); }
	inline XmlTypeMapping_t315595419 * get__mappedType_7() const { return ____mappedType_7; }
	inline XmlTypeMapping_t315595419 ** get_address_of__mappedType_7() { return &____mappedType_7; }
	inline void set__mappedType_7(XmlTypeMapping_t315595419 * value)
	{
		____mappedType_7 = value;
		Il2CppCodeGenWriteBarrier(&____mappedType_7, value);
	}

	inline static int32_t get_offset_of__type_8() { return static_cast<int32_t>(offsetof(XmlTypeMapElementInfo_t3381496463, ____type_8)); }
	inline TypeData_t3979356678 * get__type_8() const { return ____type_8; }
	inline TypeData_t3979356678 ** get_address_of__type_8() { return &____type_8; }
	inline void set__type_8(TypeData_t3979356678 * value)
	{
		____type_8 = value;
		Il2CppCodeGenWriteBarrier(&____type_8, value);
	}

	inline static int32_t get_offset_of__wrappedElement_9() { return static_cast<int32_t>(offsetof(XmlTypeMapElementInfo_t3381496463, ____wrappedElement_9)); }
	inline bool get__wrappedElement_9() const { return ____wrappedElement_9; }
	inline bool* get_address_of__wrappedElement_9() { return &____wrappedElement_9; }
	inline void set__wrappedElement_9(bool value)
	{
		____wrappedElement_9 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
