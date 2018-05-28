using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS1024_PRODUCTID
{
    public class uEnergyTestMc
    {
        enum STATUS { 
        
        UET_WARNING = 1, ///< The call succeeded but
        ///  there was a warning (use
        ///  uetGetLastError to get
        ///  details)
         UET_OK = 0, ///< Success
         UET_ERR_GENERAL = -1, ///< General error code
         UET_ERR_UNSUPPORTED_FUNCTION = -2, ///< Unsupported function called
         UET_ERR_INVALID_HANDLE = -3, ///< Invalid device handle
         UET_ERR_NO_MEM = -4, ///< Out of memory
         UET_ERR_TEST_FAILED = -5, ///< Test failed (for functions
        ///  that actually perform
        ///  tests)
         UET_ERR_SEQUENCE = -6, ///< The sequence of API calls
        ///  is incorrect
        //
        /// Parameters error codes

         UET_ERR_PARAM_INVALID = -10, ///< Invalid parameter(s) passed
        ///  to the API
         UET_ERR_PARAM_TOO_SMALL = -11, ///< A buffer (array) parameter
        ///  is too small to contain the
        ///  requested data
         UET_ERR_FILE_NOT_FOUND = -12, ///< Requested file not found

        //
        /// Device under test error codes

         UET_ERR_DUT_CONN = -20, ///< Device connection error
         UET_ERR_DUT_UNSUPPORTED = -21, ///< The connected device is not
        ///  supported
         UET_ERR_DUT_FAILED_TO_STOP = -22, ///< Device failed to stop
         UET_ERR_DUT_WRITE = -23, ///< Write to device failed
         UET_ERR_DUT_READ = -24, ///< Read from device failed
         UET_ERR_DUT_FAILED_TO_START = -25, ///< Device failed to start

        //
        /// Firmware error codes

         UET_ERR_FW_CMD_UNSPEC = -30, ///< Unspecified error for
        ///  firmware command
         UET_ERR_FW_CMD = -31, ///< Firmware command failed
         UET_ERR_FW_INIT = -32, ///< Firmware failed to
        ///  initialise
         UET_ERR_FW_TIMEOUT = -33, ///< Timeout waiting for
        ///  firmware
         UET_ERR_FW_XBV = -34, ///< Firmware XVB file error

        //
        /// Configuration Store Cache error codes

         UET_ERR_CS_CACHE_GENERAL = -40, ///< CS cache general error
         UET_ERR_CS_CACHE_NOT_INIT = -41, ///< CS cache is not initialised
        ///  (Read from chip / file
        ///  required)
         UET_ERR_CS_VERSION = -42, ///< CS version error or
        ///  incompatibility

        //
        /// SPI Errors
         UET_ERR_SPILOCK_FAILED = -50, ///< Failed to SPI-lock device
         UET_ERR_BAD_UNLOCK_KEY = -51, ///< Unlock key of invalid format



         UET_NVM_TYPE_EEPROM = 1,
         UET_NVM_TYPE_SPIFLASH = 2,

         UET_CS_MERGE_CS_ONLY = 0,
         UET_CS_MERGE_FIRMWARE_ONLY = 1,
        
        
        
        }

    }
}
