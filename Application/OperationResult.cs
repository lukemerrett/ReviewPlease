namespace Application
{
    public class OperationResult<SuccessType, FailureType>
    {
        private OperationResult()
        {

        }

        public SuccessType Result { get; private set; }

        public FailureType FailureReason { get; private set; }

        public bool IsSuccess { get; private set; }

        public static OperationResult<SuccessType, FailureType> Success(SuccessType result)
        {
            return new OperationResult<SuccessType, FailureType>
            {
                Result = result,
                IsSuccess = true
            };
        }

        public static OperationResult<SuccessType, FailureType> Failed(FailureType failureReason)
        {
            return new OperationResult<SuccessType, FailureType>
            {
                FailureReason = failureReason,
                IsSuccess = false
            };
        }
    }
}
