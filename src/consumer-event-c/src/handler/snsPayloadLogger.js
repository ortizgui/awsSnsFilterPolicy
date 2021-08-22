const convertModel = require('../service/convertModel.js');
exports.handler = async (event, context) => {
    console.info('SNS Event ', event);
    var message = event.Records[0].Sns.Message;
    console.info('Message: ', message);
    console.info(convertModel.convertSnsToLogModel(event));
}
