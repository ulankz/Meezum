#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "System_Xml_System_Xml_Serialization_XmlTypeMapMemb3057402259.h"

// System.Xml.Serialization.XmlTypeMapElementInfoList
struct XmlTypeMapElementInfoList_t1987994689;
// System.String
struct String_t;
// System.Xml.Serialization.TypeData
struct TypeData_t3979356678;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.XmlTypeMapMemberElement
struct  XmlTypeMapMemberElement_t1864082097  : public XmlTypeMapMember_t3057402259
{
public:
	// System.Xml.Serialization.XmlTypeMapElementInfoList System.Xml.Serialization.XmlTypeMapMemberElement::_elementInfo
	XmlTypeMapElementInfoList_t1987994689 * ____elementInfo_8;
	// System.String System.Xml.Serialization.XmlTypeMapMemberElement::_choiceMember
	String_t* ____choiceMember_9;
	// System.Boolean System.Xml.Serialization.XmlTypeMapMemberElement::_isTextCollector
	bool ____isTextCollector_10;
	// System.Xml.Serialization.TypeData System.Xml.Serialization.XmlTypeMapMemberElement::_choiceTypeData
	TypeData_t3979356678 * ____choiceTypeData_11;

public:
	inline static int32_t get_offset_of__elementInfo_8() { return static_cast<int32_t>(offsetof(XmlTypeMapMemberElement_t1864082097, ____elementInfo_8)); }
	inline XmlTypeMapElementInfoList_t1987994689 * get__elementInfo_8() const { return ____elementInfo_8; }
	inline XmlTypeMapElementInfoList_t1987994689 ** get_address_of__elementInfo_8() { return &____elementInfo_8; }
	inline void set__elementInfo_8(XmlTypeMapElementInfoList_t1987994689 * value)
	{
		____elementInfo_8 = value;
		Il2CppCodeGenWriteBarrier(&____elementInfo_8, value);
	}

	inline static int32_t get_offset_of__choiceMember_9() { return static_cast<int32_t>(offsetof(XmlTypeMapMemberElement_t1864082097, ____choiceMember_9)); }
	inline String_t* get__choiceMember_9() const { return ____choiceMember_9; }
	inline String_t** get_address_of__choiceMember_9() { return &____choiceMember_9; }
	inline void set__choiceMember_9(String_t* value)
	{
		____choiceMember_9 = value;
		Il2CppCodeGenWriteBarrier(&____choiceMember_9, value);
	}

	inline static int32_t get_offset_of__isTextCollector_10() { return static_cast<int32_t>(offsetof(XmlTypeMapMemberElement_t1864082097, ____isTextCollector_10)); }
	inline bool get__isTextCollector_10() const { return ____isTextCollector_10; }
	inline bool* get_address_of__isTextCollector_10() { return &____isTextCollector_10; }
	inline void set__isTextCollector_10(bool value)
	{
		____isTextCollector_10 = value;
	}

	inline static int32_t get_offset_of__choiceTypeData_11() { return static_cast<int32_t>(offsetof(XmlTypeMapMemberElement_t1864082097, ____choiceTypeData_11)); }
	inline TypeData_t3979356678 * get__choiceTypeData_11() const { return ____choiceTypeData_11; }
	inline TypeData_t3979356678 ** get_address_of__choiceTypeData_11() { return &____choiceTypeData_11; }
	inline void set__choiceTypeData_11(TypeData_t3979356678 * value)
	{
		____choiceTypeData_11 = value;
		Il2CppCodeGenWriteBarrier(&____choiceTypeData_11, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
