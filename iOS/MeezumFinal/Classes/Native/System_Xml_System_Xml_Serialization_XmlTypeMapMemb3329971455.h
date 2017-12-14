#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "System_Xml_System_Xml_Serialization_XmlTypeMapMemb3057402259.h"
#include "System_Xml_System_Xml_Schema_XmlSchemaForm1143227640.h"

// System.String
struct String_t;
// System.Xml.Serialization.XmlTypeMapping
struct XmlTypeMapping_t315595419;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.XmlTypeMapMemberAttribute
struct  XmlTypeMapMemberAttribute_t3329971455  : public XmlTypeMapMember_t3057402259
{
public:
	// System.String System.Xml.Serialization.XmlTypeMapMemberAttribute::_attributeName
	String_t* ____attributeName_8;
	// System.String System.Xml.Serialization.XmlTypeMapMemberAttribute::_namespace
	String_t* ____namespace_9;
	// System.Xml.Schema.XmlSchemaForm System.Xml.Serialization.XmlTypeMapMemberAttribute::_form
	int32_t ____form_10;
	// System.Xml.Serialization.XmlTypeMapping System.Xml.Serialization.XmlTypeMapMemberAttribute::_mappedType
	XmlTypeMapping_t315595419 * ____mappedType_11;

public:
	inline static int32_t get_offset_of__attributeName_8() { return static_cast<int32_t>(offsetof(XmlTypeMapMemberAttribute_t3329971455, ____attributeName_8)); }
	inline String_t* get__attributeName_8() const { return ____attributeName_8; }
	inline String_t** get_address_of__attributeName_8() { return &____attributeName_8; }
	inline void set__attributeName_8(String_t* value)
	{
		____attributeName_8 = value;
		Il2CppCodeGenWriteBarrier(&____attributeName_8, value);
	}

	inline static int32_t get_offset_of__namespace_9() { return static_cast<int32_t>(offsetof(XmlTypeMapMemberAttribute_t3329971455, ____namespace_9)); }
	inline String_t* get__namespace_9() const { return ____namespace_9; }
	inline String_t** get_address_of__namespace_9() { return &____namespace_9; }
	inline void set__namespace_9(String_t* value)
	{
		____namespace_9 = value;
		Il2CppCodeGenWriteBarrier(&____namespace_9, value);
	}

	inline static int32_t get_offset_of__form_10() { return static_cast<int32_t>(offsetof(XmlTypeMapMemberAttribute_t3329971455, ____form_10)); }
	inline int32_t get__form_10() const { return ____form_10; }
	inline int32_t* get_address_of__form_10() { return &____form_10; }
	inline void set__form_10(int32_t value)
	{
		____form_10 = value;
	}

	inline static int32_t get_offset_of__mappedType_11() { return static_cast<int32_t>(offsetof(XmlTypeMapMemberAttribute_t3329971455, ____mappedType_11)); }
	inline XmlTypeMapping_t315595419 * get__mappedType_11() const { return ____mappedType_11; }
	inline XmlTypeMapping_t315595419 ** get_address_of__mappedType_11() { return &____mappedType_11; }
	inline void set__mappedType_11(XmlTypeMapping_t315595419 * value)
	{
		____mappedType_11 = value;
		Il2CppCodeGenWriteBarrier(&____mappedType_11, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
