#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "System_Xml_System_Xml_Serialization_ObjectMap1719332799.h"

// System.Xml.Serialization.XmlTypeMapElementInfoList
struct XmlTypeMapElementInfoList_t1987994689;
// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.ListMap
struct  ListMap_t1787375712  : public ObjectMap_t1719332799
{
public:
	// System.Xml.Serialization.XmlTypeMapElementInfoList System.Xml.Serialization.ListMap::_itemInfo
	XmlTypeMapElementInfoList_t1987994689 * ____itemInfo_0;
	// System.String System.Xml.Serialization.ListMap::_choiceMember
	String_t* ____choiceMember_1;

public:
	inline static int32_t get_offset_of__itemInfo_0() { return static_cast<int32_t>(offsetof(ListMap_t1787375712, ____itemInfo_0)); }
	inline XmlTypeMapElementInfoList_t1987994689 * get__itemInfo_0() const { return ____itemInfo_0; }
	inline XmlTypeMapElementInfoList_t1987994689 ** get_address_of__itemInfo_0() { return &____itemInfo_0; }
	inline void set__itemInfo_0(XmlTypeMapElementInfoList_t1987994689 * value)
	{
		____itemInfo_0 = value;
		Il2CppCodeGenWriteBarrier(&____itemInfo_0, value);
	}

	inline static int32_t get_offset_of__choiceMember_1() { return static_cast<int32_t>(offsetof(ListMap_t1787375712, ____choiceMember_1)); }
	inline String_t* get__choiceMember_1() const { return ____choiceMember_1; }
	inline String_t** get_address_of__choiceMember_1() { return &____choiceMember_1; }
	inline void set__choiceMember_1(String_t* value)
	{
		____choiceMember_1 = value;
		Il2CppCodeGenWriteBarrier(&____choiceMember_1, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
