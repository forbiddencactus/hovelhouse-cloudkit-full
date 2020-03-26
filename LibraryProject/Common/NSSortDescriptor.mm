//
//  NSSortDescriptor.mm
//
//  Created by Jonathan on 12/31/19.
//  Copyright © 2019 HovelHouseApps. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <CloudKit/CloudKit.h>
#import "NSSortDescriptor.h"
#import "Converters.h"

extern "C" {

//ClassMethods
//InitMethods
void* NSSortDescriptor_initWithCoder(
    void* coder,
    void** exceptionPtr)
{
    @try 
    {
        NSSortDescriptor* iNSSortDescriptor = [[NSSortDescriptor alloc] initWithCoder:(__bridge NSCoder*) coder];
            return (__bridge_retained void*) iNSSortDescriptor;
    }
    @catch(NSException* ex)
    {
        *exceptionPtr = (__bridge_retained void*)ex;
    }

    return nil;
}

//InstanceMethods
//VoidMethods
void NSSortDescriptor_allowEvaluation(
    void* ptr,
    void** exception
    )
{
	@try 
	{
		NSSortDescriptor* iNSSortDescriptor = (__bridge NSSortDescriptor*) ptr;
	    [iNSSortDescriptor allowEvaluation];
	}
	@catch(NSException* ex)
	{
		*exception = (__bridge_retained void*) ex;
	}
	
}



//Properties

bool NSSortDescriptor_GetPropAscending(void* ptr)
{
	NSSortDescriptor* iNSSortDescriptor = (__bridge NSSortDescriptor*) ptr;
	BOOL val = [iNSSortDescriptor ascending];
	return val;
}

const char* NSSortDescriptor_GetPropKey(void* ptr)
{
	NSSortDescriptor* iNSSortDescriptor = (__bridge NSSortDescriptor*) ptr;
	NSString* val = [iNSSortDescriptor key];
	return [val UTF8String];
}


void NSSortDescriptor_Dispose(void* ptr)
{
    NSSortDescriptor* val = (__bridge NSSortDescriptor*) ptr;
    if(val != nil)
    {
        CFRelease(ptr);
    }
    //NSLog(@"Dispose...NSSortDescriptor");
}

}
