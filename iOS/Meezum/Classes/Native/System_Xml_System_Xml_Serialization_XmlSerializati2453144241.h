#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object2689449295.h"

// System.Xml.Serialization.XmlSerializationReaderInterpreter
struct XmlSerializationReaderInterpreter_t2056927484;
// System.Xml.Serialization.XmlTypeMapping
struct XmlTypeMapping_t315595419;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.XmlSerializationReaderInterpreter/ReaderCallbackInfo
struct  ReaderCallbackInfo_t2453144241  : public Il2CppObject
{
public:
	// System.Xml.Serialization.XmlSerializationReaderInterpreter System.Xml.Serialization.XmlSerializationReaderInterpreter/ReaderCallbackInfo::_sri
	XmlSerializationReaderInterpreter_t2056927484 * ____sri_0;
	// System.Xml.Serialization.XmlTypeMapping System.Xml.Serialization.XmlSerializationReaderInterpreter/ReaderCallbackInfo::_typeMap
	XmlTypeMapping_t315595419 * ____typeMap_1;

public:
	inline static int32_t get_offset_of__sri_0() { return static_cast<int32_t>(offsetof(ReaderCallbackInfo_t2453144241, ____sri_0)); }
	inline XmlSerializationReaderInterpreter_t2056927484 * get__sri_0() const { return ____sri_0; }
	inline XmlSerializationReaderInterpreter_t2056927484 ** get_address_of__sri_0() { return &____sri_0; }
	inline void set__sri_0(XmlSerializationReaderInterpreter_t2056927484 * value)
	{
		____sri_0 = value;
		Il2CppCodeGenWriteBarrier(&____sri_0, value);
	}

	inline static int32_t get_offset_of__typeMap_1() { return static_cast<int32_t>(offsetof(ReaderCallbackInfo_t2453144241, ____typeMap_1)); }
	inline XmlTypeMapping_t315595419 * get__typeMap_1() const { return ____typeMap_1; }
	inline XmlTypeMapping_t315595419 ** get_address_of__typeMap_1() { return &____typeMap_1; }
	inline void set__typeMap_1(XmlTypeMapping_t315595419 * value)
	{
		____typeMap_1 = value;
		Il2CppCodeGenWriteBarrier(&____typeMap_1, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
