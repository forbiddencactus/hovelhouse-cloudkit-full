//
//  CKAsset.h
//
//  Created by Jonathan Culp <jonathanculp@gmail.com> on 03/26/2020
//  Copyright © 2020 HovelHouseApps. All rights reserved.
//  Unauthorized copying of this file, via any medium is strictly prohibited
//  Proprietary and confidential
//

#import <Foundation/Foundation.h>
#import "Callbacks.h"

// Class Methods 

// Init Methods 
extern "C" void* CKAsset_initWithFileURL(
    void* fileURL,
    void** exceptionPtr);


// Instance methods 

// Void methods 

// Properties 
extern "C" void* CKAsset_GetPropFileURL(void* ptr);



extern "C" void CKAsset_Dispose(void* ptr);
