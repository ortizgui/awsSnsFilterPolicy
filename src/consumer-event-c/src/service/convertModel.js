function convertSnsToLogModel(event){
    console.info('convertSnstoLogModel')
    var model = {
        message: event.Records[0].Sns.Message
    }

    return model;
}

module.exports = { convertSnsToLogModel };