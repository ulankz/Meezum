#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "System_Xml_System_Xml_Serialization_XmlTypeMapMembe755220835.h"

// System.Xml.Serialization.ListMap
struct ListMap_t1787375712;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.XmlTypeMapMemberFlatList
struct  XmlTypeMapMemberFlatList_t2275030030  : public XmlTypeMapMemberExpandable_t755220835
{
public:
	// System.Xml.Serialization.ListMap System.Xml.Serialization.XmlTypeMapMemberFlatList::_listMap
	ListMap_t1787375712 * ____listMap_13;

public:
	inline static int32_t get_offset_of__listMap_13() { return static_cast<int32_t>(offsetof(XmlTypeMapMemberFlatList_t2275030030, ____listMap_13)); }
	inline ListMap_t1787375712 * get__listMap_13() const { return ____listMap_13; }
	inline ListMap_t1787375712 ** get_address_of__listMap_13() { return &____listMap_13; }
	inline void set__listMap_13(ListMap_t1787375712 * value)
	{
		____listMap_13 = value;
		Il2CppCodeGenWriteBarrier(&____listMap_13, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
